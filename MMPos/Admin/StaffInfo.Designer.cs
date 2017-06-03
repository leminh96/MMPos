namespace MMPos
{
    partial class StaffInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.staffid_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.Staff_ListView = new MyListView();
            this.Help_Lable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(115, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 37);
            this.label1.TabIndex = 37;
            this.label1.Text = "Staffs Info";
            // 
            // password_textbox
            // 
            this.password_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textbox.Location = new System.Drawing.Point(65, 300);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(291, 22);
            this.password_textbox.TabIndex = 43;
            // 
            // name_textbox
            // 
            this.name_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textbox.Location = new System.Drawing.Point(65, 230);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(291, 22);
            this.name_textbox.TabIndex = 42;
            // 
            // staffid_textbox
            // 
            this.staffid_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffid_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffid_textbox.Location = new System.Drawing.Point(65, 160);
            this.staffid_textbox.Name = "staffid_textbox";
            this.staffid_textbox.Size = new System.Drawing.Size(291, 22);
            this.staffid_textbox.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 40;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Staff ID";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Olive;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(211, 545);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(145, 105);
            this.Close.TabIndex = 45;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.Olive;
            this.OK.FlatAppearance.BorderSize = 0;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(65, 545);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(145, 105);
            this.OK.TabIndex = 44;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            // 
            // Staff_ListView
            // 
            this.Staff_ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Staff_ListView.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_ListView.FullRowSelect = true;
            this.Staff_ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Staff_ListView.Location = new System.Drawing.Point(417, 27);
            this.Staff_ListView.MultiSelect = false;
            this.Staff_ListView.Name = "Staff_ListView";
            this.Staff_ListView.Size = new System.Drawing.Size(935, 705);
            this.Staff_ListView.TabIndex = 46;
            this.Staff_ListView.UseCompatibleStateImageBehavior = false;
            this.Staff_ListView.View = System.Windows.Forms.View.Details;
            // 
            // Help_Lable
            // 
            this.Help_Lable.AutoSize = true;
            this.Help_Lable.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help_Lable.Location = new System.Drawing.Point(60, 735);
            this.Help_Lable.Name = "Help_Lable";
            this.Help_Lable.Size = new System.Drawing.Size(281, 17);
            this.Help_Lable.TabIndex = 47;
            this.Help_Lable.Text = "* Fill staff information in text boxes, then press OK";
            // 
            // StaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 733);
            this.Controls.Add(this.Help_Lable);
            this.Controls.Add(this.Staff_ListView);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.staffid_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "StaffInfo";
            this.Text = "StaffDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox password_textbox;
        protected System.Windows.Forms.TextBox name_textbox;
        protected System.Windows.Forms.TextBox staffid_textbox;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button Close;
        protected System.Windows.Forms.Button OK;
        protected MyListView Staff_ListView;
        protected System.Windows.Forms.Label Help_Lable;
    }
}