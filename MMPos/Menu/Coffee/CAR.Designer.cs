namespace MMPos.Menu.Coffee
{
    partial class CAR
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CAR_Hot = new System.Windows.Forms.Button();
            this.CAR_Small = new System.Windows.Forms.Button();
            this.CAR_Large = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CAR_Hot
            // 
            this.CAR_Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CAR_Hot.FlatAppearance.BorderSize = 0;
            this.CAR_Hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CAR_Hot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CAR_Hot.ForeColor = System.Drawing.Color.White;
            this.CAR_Hot.Location = new System.Drawing.Point(0, 202);
            this.CAR_Hot.Name = "CAR_Hot";
            this.CAR_Hot.Size = new System.Drawing.Size(480, 100);
            this.CAR_Hot.TabIndex = 36;
            this.CAR_Hot.Text = "Caramel Latte (Hot)";
            this.CAR_Hot.UseVisualStyleBackColor = false;
            this.CAR_Hot.Click += new System.EventHandler(this.CAR_Hot_Click);
            // 
            // CAR_Small
            // 
            this.CAR_Small.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CAR_Small.FlatAppearance.BorderSize = 0;
            this.CAR_Small.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CAR_Small.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CAR_Small.ForeColor = System.Drawing.Color.White;
            this.CAR_Small.Location = new System.Drawing.Point(0, 101);
            this.CAR_Small.Name = "CAR_Small";
            this.CAR_Small.Size = new System.Drawing.Size(480, 100);
            this.CAR_Small.TabIndex = 35;
            this.CAR_Small.Text = "Caramel Latte (S)";
            this.CAR_Small.UseVisualStyleBackColor = false;
            this.CAR_Small.Click += new System.EventHandler(this.CAR_Small_Click);
            // 
            // CAR_Large
            // 
            this.CAR_Large.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CAR_Large.FlatAppearance.BorderSize = 0;
            this.CAR_Large.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CAR_Large.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CAR_Large.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CAR_Large.Location = new System.Drawing.Point(0, 0);
            this.CAR_Large.Name = "CAR_Large";
            this.CAR_Large.Size = new System.Drawing.Size(480, 100);
            this.CAR_Large.TabIndex = 34;
            this.CAR_Large.Text = "Caramel Latte (L)";
            this.CAR_Large.UseVisualStyleBackColor = false;
            this.CAR_Large.Click += new System.EventHandler(this.CAR_Large_Click);
            // 
            // CAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.CAR_Hot);
            this.Controls.Add(this.CAR_Small);
            this.Controls.Add(this.CAR_Large);
            this.Name = "CAR";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CAR_Hot;
        private System.Windows.Forms.Button CAR_Small;
        private System.Windows.Forms.Button CAR_Large;
    }
}
