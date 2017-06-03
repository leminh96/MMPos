namespace MMPos.Menu.Tea
{
    partial class GL
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
            this.GL_Hot = new System.Windows.Forms.Button();
            this.GL_Small = new System.Windows.Forms.Button();
            this.GL_Large = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GL_Hot
            // 
            this.GL_Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.GL_Hot.FlatAppearance.BorderSize = 0;
            this.GL_Hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GL_Hot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GL_Hot.ForeColor = System.Drawing.Color.White;
            this.GL_Hot.Location = new System.Drawing.Point(0, 202);
            this.GL_Hot.Name = "GL_Hot";
            this.GL_Hot.Size = new System.Drawing.Size(480, 100);
            this.GL_Hot.TabIndex = 45;
            this.GL_Hot.Text = "Green Tea Latte (Hot)";
            this.GL_Hot.UseVisualStyleBackColor = false;
            this.GL_Hot.Click += new System.EventHandler(this.GL_Hot_Click);
            // 
            // GL_Small
            // 
            this.GL_Small.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.GL_Small.FlatAppearance.BorderSize = 0;
            this.GL_Small.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GL_Small.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GL_Small.ForeColor = System.Drawing.Color.White;
            this.GL_Small.Location = new System.Drawing.Point(0, 101);
            this.GL_Small.Name = "GL_Small";
            this.GL_Small.Size = new System.Drawing.Size(480, 100);
            this.GL_Small.TabIndex = 44;
            this.GL_Small.Text = "Green Tea Latte (S)";
            this.GL_Small.UseVisualStyleBackColor = false;
            this.GL_Small.Click += new System.EventHandler(this.GL_Small_Click);
            // 
            // GL_Large
            // 
            this.GL_Large.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.GL_Large.FlatAppearance.BorderSize = 0;
            this.GL_Large.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GL_Large.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GL_Large.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GL_Large.Location = new System.Drawing.Point(0, 0);
            this.GL_Large.Name = "GL_Large";
            this.GL_Large.Size = new System.Drawing.Size(480, 100);
            this.GL_Large.TabIndex = 43;
            this.GL_Large.Text = "Green Tea Latte (L)";
            this.GL_Large.UseVisualStyleBackColor = false;
            this.GL_Large.Click += new System.EventHandler(this.GL_Large_Click);
            // 
            // GL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.GL_Hot);
            this.Controls.Add(this.GL_Small);
            this.Controls.Add(this.GL_Large);
            this.Name = "GL";
            this.Size = new System.Drawing.Size(483, 299);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GL_Hot;
        private System.Windows.Forms.Button GL_Small;
        private System.Windows.Forms.Button GL_Large;
    }
}
