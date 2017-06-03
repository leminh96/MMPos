namespace MMPos.Menu.Coffee
{
    partial class LA
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
            this.LA_Hot = new System.Windows.Forms.Button();
            this.LA_Small = new System.Windows.Forms.Button();
            this.LA_Large = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LA_Hot
            // 
            this.LA_Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LA_Hot.FlatAppearance.BorderSize = 0;
            this.LA_Hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LA_Hot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LA_Hot.ForeColor = System.Drawing.Color.White;
            this.LA_Hot.Location = new System.Drawing.Point(0, 202);
            this.LA_Hot.Name = "LA_Hot";
            this.LA_Hot.Size = new System.Drawing.Size(480, 100);
            this.LA_Hot.TabIndex = 30;
            this.LA_Hot.Text = "Coffee Latte (Hot)";
            this.LA_Hot.UseVisualStyleBackColor = false;
            this.LA_Hot.Click += new System.EventHandler(this.LA_Hot_Click);
            // 
            // LA_Small
            // 
            this.LA_Small.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LA_Small.FlatAppearance.BorderSize = 0;
            this.LA_Small.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LA_Small.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LA_Small.ForeColor = System.Drawing.Color.White;
            this.LA_Small.Location = new System.Drawing.Point(0, 101);
            this.LA_Small.Name = "LA_Small";
            this.LA_Small.Size = new System.Drawing.Size(480, 100);
            this.LA_Small.TabIndex = 29;
            this.LA_Small.Text = "Coffee Latte (S)";
            this.LA_Small.UseVisualStyleBackColor = false;
            this.LA_Small.Click += new System.EventHandler(this.LA_Small_Click);
            // 
            // LA_Large
            // 
            this.LA_Large.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LA_Large.FlatAppearance.BorderSize = 0;
            this.LA_Large.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LA_Large.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LA_Large.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LA_Large.Location = new System.Drawing.Point(0, 0);
            this.LA_Large.Name = "LA_Large";
            this.LA_Large.Size = new System.Drawing.Size(480, 100);
            this.LA_Large.TabIndex = 28;
            this.LA_Large.Text = "Coffee Latte (L)";
            this.LA_Large.UseVisualStyleBackColor = false;
            this.LA_Large.Click += new System.EventHandler(this.LA_Large_Click);
            // 
            // LA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.LA_Hot);
            this.Controls.Add(this.LA_Small);
            this.Controls.Add(this.LA_Large);
            this.Name = "LA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LA_Hot;
        private System.Windows.Forms.Button LA_Small;
        private System.Windows.Forms.Button LA_Large;
    }
}
