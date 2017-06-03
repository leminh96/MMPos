namespace MMPos.Menu.Coffee
{
    partial class CAP
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
            this.CAP_Hot = new System.Windows.Forms.Button();
            this.CAP_Small = new System.Windows.Forms.Button();
            this.CAP_Large = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CAP_Hot
            // 
            this.CAP_Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CAP_Hot.FlatAppearance.BorderSize = 0;
            this.CAP_Hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CAP_Hot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CAP_Hot.ForeColor = System.Drawing.Color.White;
            this.CAP_Hot.Location = new System.Drawing.Point(0, 202);
            this.CAP_Hot.Name = "CAP_Hot";
            this.CAP_Hot.Size = new System.Drawing.Size(480, 100);
            this.CAP_Hot.TabIndex = 24;
            this.CAP_Hot.Text = "Cappuccino (Hot)";
            this.CAP_Hot.UseVisualStyleBackColor = false;
            this.CAP_Hot.Click += new System.EventHandler(this.CAP_Hot_Click);
            // 
            // CAP_Small
            // 
            this.CAP_Small.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CAP_Small.FlatAppearance.BorderSize = 0;
            this.CAP_Small.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CAP_Small.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CAP_Small.ForeColor = System.Drawing.Color.White;
            this.CAP_Small.Location = new System.Drawing.Point(0, 101);
            this.CAP_Small.Name = "CAP_Small";
            this.CAP_Small.Size = new System.Drawing.Size(480, 100);
            this.CAP_Small.TabIndex = 23;
            this.CAP_Small.Text = "Cappuccino (S)";
            this.CAP_Small.UseVisualStyleBackColor = false;
            this.CAP_Small.Click += new System.EventHandler(this.CAP_Small_Click);
            // 
            // CAP_Large
            // 
            this.CAP_Large.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CAP_Large.FlatAppearance.BorderSize = 0;
            this.CAP_Large.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CAP_Large.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CAP_Large.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CAP_Large.Location = new System.Drawing.Point(0, 0);
            this.CAP_Large.Name = "CAP_Large";
            this.CAP_Large.Size = new System.Drawing.Size(480, 100);
            this.CAP_Large.TabIndex = 22;
            this.CAP_Large.Text = "Cappuccino (L)";
            this.CAP_Large.UseVisualStyleBackColor = false;
            this.CAP_Large.Click += new System.EventHandler(this.CAP_Large_Click);
            // 
            // CAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.CAP_Hot);
            this.Controls.Add(this.CAP_Small);
            this.Controls.Add(this.CAP_Large);
            this.Name = "CAP";
            this.Size = new System.Drawing.Size(483, 299);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CAP_Hot;
        private System.Windows.Forms.Button CAP_Small;
        private System.Windows.Forms.Button CAP_Large;
    }
}
