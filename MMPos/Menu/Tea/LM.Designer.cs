namespace MMPos.Menu.Tea
{
    partial class LM
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
            this.LM_Hot = new System.Windows.Forms.Button();
            this.LM_Small = new System.Windows.Forms.Button();
            this.LM_Large = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LM_Hot
            // 
            this.LM_Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LM_Hot.FlatAppearance.BorderSize = 0;
            this.LM_Hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LM_Hot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LM_Hot.ForeColor = System.Drawing.Color.White;
            this.LM_Hot.Location = new System.Drawing.Point(0, 202);
            this.LM_Hot.Name = "LM_Hot";
            this.LM_Hot.Size = new System.Drawing.Size(480, 100);
            this.LM_Hot.TabIndex = 27;
            this.LM_Hot.Text = "Lemon Black Tea (Hot)";
            this.LM_Hot.UseVisualStyleBackColor = false;
            this.LM_Hot.Click += new System.EventHandler(this.LM_Hot_Click);
            // 
            // LM_Small
            // 
            this.LM_Small.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LM_Small.FlatAppearance.BorderSize = 0;
            this.LM_Small.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LM_Small.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LM_Small.ForeColor = System.Drawing.Color.White;
            this.LM_Small.Location = new System.Drawing.Point(0, 101);
            this.LM_Small.Name = "LM_Small";
            this.LM_Small.Size = new System.Drawing.Size(480, 100);
            this.LM_Small.TabIndex = 26;
            this.LM_Small.Text = "Lemon Black Tea (S)";
            this.LM_Small.UseVisualStyleBackColor = false;
            this.LM_Small.Click += new System.EventHandler(this.LM_Small_Click);
            // 
            // LM_Large
            // 
            this.LM_Large.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LM_Large.FlatAppearance.BorderSize = 0;
            this.LM_Large.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LM_Large.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LM_Large.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LM_Large.Location = new System.Drawing.Point(0, 0);
            this.LM_Large.Name = "LM_Large";
            this.LM_Large.Size = new System.Drawing.Size(480, 100);
            this.LM_Large.TabIndex = 25;
            this.LM_Large.Text = "Lemon Black Tea (L)";
            this.LM_Large.UseVisualStyleBackColor = false;
            this.LM_Large.Click += new System.EventHandler(this.LM_Large_Click);
            // 
            // LM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.LM_Hot);
            this.Controls.Add(this.LM_Small);
            this.Controls.Add(this.LM_Large);
            this.Name = "LM";
            this.Size = new System.Drawing.Size(483, 299);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LM_Hot;
        private System.Windows.Forms.Button LM_Small;
        private System.Windows.Forms.Button LM_Large;
    }
}
