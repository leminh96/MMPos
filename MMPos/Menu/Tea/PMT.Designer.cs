namespace MMPos.Menu.Tea
{
    partial class PMT
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
            this.PMT_Hot = new System.Windows.Forms.Button();
            this.PMT_Small = new System.Windows.Forms.Button();
            this.PMT_Large = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PMT_Hot
            // 
            this.PMT_Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PMT_Hot.FlatAppearance.BorderSize = 0;
            this.PMT_Hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PMT_Hot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PMT_Hot.ForeColor = System.Drawing.Color.White;
            this.PMT_Hot.Location = new System.Drawing.Point(0, 202);
            this.PMT_Hot.Name = "PMT_Hot";
            this.PMT_Hot.Size = new System.Drawing.Size(480, 100);
            this.PMT_Hot.TabIndex = 48;
            this.PMT_Hot.Text = "Peach Milk Tea (Hot)";
            this.PMT_Hot.UseVisualStyleBackColor = false;
            this.PMT_Hot.Click += new System.EventHandler(this.PMT_Hot_Click);
            // 
            // PMT_Small
            // 
            this.PMT_Small.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PMT_Small.FlatAppearance.BorderSize = 0;
            this.PMT_Small.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PMT_Small.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PMT_Small.ForeColor = System.Drawing.Color.White;
            this.PMT_Small.Location = new System.Drawing.Point(0, 101);
            this.PMT_Small.Name = "PMT_Small";
            this.PMT_Small.Size = new System.Drawing.Size(480, 100);
            this.PMT_Small.TabIndex = 47;
            this.PMT_Small.Text = "Peach Milk Tea (S)";
            this.PMT_Small.UseVisualStyleBackColor = false;
            this.PMT_Small.Click += new System.EventHandler(this.PMT_Small_Click);
            // 
            // PMT_Large
            // 
            this.PMT_Large.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PMT_Large.FlatAppearance.BorderSize = 0;
            this.PMT_Large.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PMT_Large.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PMT_Large.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PMT_Large.Location = new System.Drawing.Point(0, 0);
            this.PMT_Large.Name = "PMT_Large";
            this.PMT_Large.Size = new System.Drawing.Size(480, 100);
            this.PMT_Large.TabIndex = 46;
            this.PMT_Large.Text = "Peach Milk Tea (L)";
            this.PMT_Large.UseVisualStyleBackColor = false;
            this.PMT_Large.Click += new System.EventHandler(this.PMT_Large_Click);
            // 
            // PMT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.PMT_Hot);
            this.Controls.Add(this.PMT_Small);
            this.Controls.Add(this.PMT_Large);
            this.Name = "PMT";
            this.Size = new System.Drawing.Size(483, 299);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PMT_Hot;
        private System.Windows.Forms.Button PMT_Small;
        private System.Windows.Forms.Button PMT_Large;
    }
}
