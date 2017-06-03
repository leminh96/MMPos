namespace MMPos.Menu.Tea
{
    partial class JAC
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
            this.JAS_Hot = new System.Windows.Forms.Button();
            this.JAS_Small = new System.Windows.Forms.Button();
            this.JAS_Large = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JAS_Hot
            // 
            this.JAS_Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.JAS_Hot.FlatAppearance.BorderSize = 0;
            this.JAS_Hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JAS_Hot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.JAS_Hot.ForeColor = System.Drawing.Color.White;
            this.JAS_Hot.Location = new System.Drawing.Point(0, 202);
            this.JAS_Hot.Name = "JAS_Hot";
            this.JAS_Hot.Size = new System.Drawing.Size(480, 100);
            this.JAS_Hot.TabIndex = 36;
            this.JAS_Hot.Text = "Lychee Jasmine Tea (Hot)";
            this.JAS_Hot.UseVisualStyleBackColor = false;
            this.JAS_Hot.Click += new System.EventHandler(this.JAS_Hot_Click);
            // 
            // JAS_Small
            // 
            this.JAS_Small.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.JAS_Small.FlatAppearance.BorderSize = 0;
            this.JAS_Small.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JAS_Small.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.JAS_Small.ForeColor = System.Drawing.Color.White;
            this.JAS_Small.Location = new System.Drawing.Point(0, 101);
            this.JAS_Small.Name = "JAS_Small";
            this.JAS_Small.Size = new System.Drawing.Size(480, 100);
            this.JAS_Small.TabIndex = 35;
            this.JAS_Small.Text = "Lychee Jasmine Tea (S)";
            this.JAS_Small.UseVisualStyleBackColor = false;
            this.JAS_Small.Click += new System.EventHandler(this.JAS_Small_Click);
            // 
            // JAS_Large
            // 
            this.JAS_Large.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.JAS_Large.FlatAppearance.BorderSize = 0;
            this.JAS_Large.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JAS_Large.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.JAS_Large.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.JAS_Large.Location = new System.Drawing.Point(0, 0);
            this.JAS_Large.Name = "JAS_Large";
            this.JAS_Large.Size = new System.Drawing.Size(480, 100);
            this.JAS_Large.TabIndex = 34;
            this.JAS_Large.Text = "Lychee Jasmine Tea (L)";
            this.JAS_Large.UseVisualStyleBackColor = false;
            this.JAS_Large.Click += new System.EventHandler(this.JAS_Large_Click);
            // 
            // JAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.JAS_Hot);
            this.Controls.Add(this.JAS_Small);
            this.Controls.Add(this.JAS_Large);
            this.Name = "JAC";
            this.Size = new System.Drawing.Size(483, 299);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button JAS_Hot;
        private System.Windows.Forms.Button JAS_Small;
        private System.Windows.Forms.Button JAS_Large;
    }
}
