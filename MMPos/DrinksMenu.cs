using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace MMPos
{
    public class DrinksMenu
    {
        private List<DrinkContent> listDrink;

        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;

        private static DrinksMenu _instance;
        public static DrinksMenu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DrinksMenu();
                }
                return _instance;
            }
        }

        DrinksMenu()
        {
            listDrink = new List<DrinkContent>();
            ConnectDB();
        }

        public DrinkContent GetDrink(string id)
        {
            for(int i = 0; i < listDrink.Count; i++)
            {
                if(id == listDrink[i].Id)
                {
                    return listDrink[i];
                }
            }
            return null;
        } 

        public string GetName(string id)
        {
            for (int i = 0; i < listDrink.Count; i++)
            {
                if (id == listDrink[i].Id)
                {
                    return listDrink[i].Name;
                }
            }
            return string.Empty;
        }

        public int SetName(string id, string name)
        {
            for (int i = 0; i < listDrink.Count; i++)
            {
                if (id == listDrink[i].Id)
                {
                    listDrink[i].Name = name;
                    return 1;
                }
            }
            return 0;
        }

        public int GetPrice(string id)
        {
            for (int i = 0; i < listDrink.Count; i++)
            {
                if (id == listDrink[i].Id)
                {
                    return listDrink[i].Price;
                }
            }
            return 0;
        }

        public int SetPrice(string id, int price)
        {
            for (int i = 0; i < listDrink.Count; i++)
            {
                if (id == listDrink[i].Id)
                {
                    listDrink[i].Price = price;
                    return 1;
                }
            }
            return 0;
        }

        public int Count()
        {
            return listDrink.Count;
        }

        public void Load()
        {
            int count = CountDrinksFromDB();
            
            //Load db
            DataTable dt1 = new DataTable();
            cmd = new SqlCommand("Select * from Drinks", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            dt1.Locale = System.Globalization.CultureInfo.InvariantCulture;
            da1.Fill(dt1);

            for (int i = 0; i < count; i++)
            {
                string id = dt1.Rows[i][0].ToString();
                string name = dt1.Rows[i][1].ToString();
                int price = (int)dt1.Rows[i][2];
                DrinkContent drink = new DrinkContent(id, name, price);
                listDrink.Add(drink);
            }
        }

        public void Update()
        {
            for (int i = 0; i < listDrink.Count; i++)
            {
                string id = listDrink[i].Id;
                int price = listDrink[i].Price;
                cmd = new SqlCommand("Update Drinks set Price = @Price where ID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.ExecuteNonQuery();
            }
        }

        public void ConnectDB()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-79SGS5L\MINHSQLSERVER;Initial Catalog=MMPos;Integrated Security=True");
            try
            {
                con.Open();
            }
            catch
            {
                
            }
        }
        //get name of the drink
        private string GetNameFromDB(string temp)
        {
            DataTable dt1 = new DataTable();
            cmd = new SqlCommand("Select Name from Drinks where ID = @DrinkID", con);
            cmd.Parameters.AddWithValue("@DrinkID", temp);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            dt1.Locale = System.Globalization.CultureInfo.InvariantCulture;
            da1.Fill(dt1);
            return dt1.Rows[0][0].ToString();
        }

        //get price of the drink
        private int GetPriceFromDB(string temp)
        {
            DataTable dt1 = new DataTable();
            cmd = new SqlCommand("Select Price from Drinks where ID = @DrinkID", con);
            cmd.Parameters.AddWithValue("@DrinkID", temp);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            dt1.Locale = System.Globalization.CultureInfo.InvariantCulture;
            da1.Fill(dt1);
            return (int)dt1.Rows[0][0];
        }

        private int CountDrinksFromDB()
        {
            try
            {
                dt = new DataTable();
                cmd = new SqlCommand("Select count(ID) from Drinks", con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return -1;
            }
            da = new SqlDataAdapter(cmd);
            dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
            da.Fill(dt);
            return (int)dt.Rows[0][0];
        }
    }

    public class DrinkContent
    {
        private string id;
        private string name;
        private int price;
        public DrinkContent(string id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
    }
}
