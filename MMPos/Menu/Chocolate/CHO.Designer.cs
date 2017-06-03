namespace MMPos.Menu.Chocolate
{
    partial class CHO
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
            this.CHO_Hot = new System.Windows.Forms.Button();
            this.CHO_Small = new System.Windows.Forms.Button();
            this.CHO_Large = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CHO_Hot
            // 
            this.CHO_Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CHO_Hot.FlatAppearance.BorderSize = 0;
            this.CHO_Hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHO_Hot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CHO_Hot.ForeColor = System.Drawing.Color.White;
            this.CHO_Hot.Location = new System.Drawing.Point(0, 202);
            this.CHO_Hot.Name = "CHO_Hot";
            this.CHO_Hot.Size = new System.Drawing.Size(480, 100);
            this.CHO_Hot.TabIndex = 48;
            this.CHO_Hot.Text = "Chocolate Latte (Hot)";
            this.CHO_Hot.UseVisualStyleBackColor = false;
            this.CHO_Hot.Click += new System.EventHandler(this.CHO_Hot_Click);
            // 
            // CHO_Small
            // 
            this.CHO_Small.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CHO_Small.FlatAppearance.BorderSize = 0;
            this.CHO_Small.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHO_Small.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CHO_Small.ForeColor = System.Drawing.Color.White;
            this.CHO_Small.Location = new System.Drawing.Point(0, 101);
            this.CHO_Small.Name = "CHO_Small";
            this.CHO_Small.Size = new System.Drawing.Size(480, 100);
            this.CHO_Small.TabIndex = 47;
            this.CHO_Small.Text = "Chocolate Latte (S)";
            this.CHO_Small.UseVisualStyleBackColor = false;
            this.CHO_Small.Click += new System.EventHandler(this.CHO_Small_Click);
            // 
            // CHO_Large
            // 
            this.CHO_Large.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CHO_Large.FlatAppearance.BorderSize = 0;
            this.CHO_Large.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHO_Large.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CHO_Large.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CHO_Large.Location = new System.Drawing.Point(0, 0);
            this.CHO_Large.Name = "CHO_Large";
            this.CHO_Large.Size = new System.Drawing.Size(480, 100);
            this.CHO_Large.TabIndex = 46;
            this.CHO_Large.Text = "Chocolate Latte (L)";
            this.CHO_Large.UseVisualStyleBackColor = false;
            this.CHO_Large.Click += new System.EventHandler(this.CHO_Large_Click);
            // 
            // CHO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.CHO_Hot);
            this.Controls.Add(this.CHO_Small);
            this.Controls.Add(this.CHO_Large);
            this.Name = "CHO";
            this.Size = new System.Drawing.Size(483, 299);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CHO_Hot;
        private System.Windows.Forms.Button CHO_Small;
        private System.Windows.Forms.Button CHO_Large;
    }
}
