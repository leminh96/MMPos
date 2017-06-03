namespace MMPos.Menu.Tea
{
    partial class PT
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
            this.PT_Hot = new System.Windows.Forms.Button();
            this.PT_Small = new System.Windows.Forms.Button();
            this.PT_Large = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PT_Hot
            // 
            this.PT_Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PT_Hot.FlatAppearance.BorderSize = 0;
            this.PT_Hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PT_Hot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PT_Hot.ForeColor = System.Drawing.Color.White;
            this.PT_Hot.Location = new System.Drawing.Point(0, 202);
            this.PT_Hot.Name = "PT_Hot";
            this.PT_Hot.Size = new System.Drawing.Size(480, 100);
            this.PT_Hot.TabIndex = 33;
            this.PT_Hot.Text = "Peach Black Tea (Hot)";
            this.PT_Hot.UseVisualStyleBackColor = false;
            this.PT_Hot.Click += new System.EventHandler(this.PT_Hot_Click);
            // 
            // PT_Small
            // 
            this.PT_Small.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PT_Small.FlatAppearance.BorderSize = 0;
            this.PT_Small.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PT_Small.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PT_Small.ForeColor = System.Drawing.Color.White;
            this.PT_Small.Location = new System.Drawing.Point(0, 101);
            this.PT_Small.Name = "PT_Small";
            this.PT_Small.Size = new System.Drawing.Size(480, 100);
            this.PT_Small.TabIndex = 32;
            this.PT_Small.Text = "Peach Black Tea (S)";
            this.PT_Small.UseVisualStyleBackColor = false;
            this.PT_Small.Click += new System.EventHandler(this.PT_Small_Click);
            // 
            // PT_Large
            // 
            this.PT_Large.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PT_Large.FlatAppearance.BorderSize = 0;
            this.PT_Large.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PT_Large.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PT_Large.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PT_Large.Location = new System.Drawing.Point(0, 0);
            this.PT_Large.Name = "PT_Large";
            this.PT_Large.Size = new System.Drawing.Size(480, 100);
            this.PT_Large.TabIndex = 31;
            this.PT_Large.Text = "Peach Black Tea (L)";
            this.PT_Large.UseVisualStyleBackColor = false;
            this.PT_Large.Click += new System.EventHandler(this.PT_Large_Click);
            // 
            // PT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.PT_Hot);
            this.Controls.Add(this.PT_Small);
            this.Controls.Add(this.PT_Large);
            this.Name = "PT";
            this.Size = new System.Drawing.Size(483, 299);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PT_Hot;
        private System.Windows.Forms.Button PT_Small;
        private System.Windows.Forms.Button PT_Large;
    }
}
