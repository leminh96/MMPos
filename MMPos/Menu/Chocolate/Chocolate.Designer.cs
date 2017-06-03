namespace MMPos.Menu.Chocolate
{
    partial class Chocolate
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
            this.CHOM = new System.Windows.Forms.Button();
            this.CHOF = new System.Windows.Forms.Button();
            this.CHO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CHOM
            // 
            this.CHOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CHOM.FlatAppearance.BorderSize = 0;
            this.CHOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHOM.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CHOM.ForeColor = System.Drawing.Color.White;
            this.CHOM.Location = new System.Drawing.Point(322, 0);
            this.CHOM.Name = "CHOM";
            this.CHOM.Size = new System.Drawing.Size(160, 100);
            this.CHOM.TabIndex = 27;
            this.CHOM.Text = "Chocolate Macchiato";
            this.CHOM.UseVisualStyleBackColor = false;
            this.CHOM.Click += new System.EventHandler(this.CHOM_Click);
            // 
            // CHOF
            // 
            this.CHOF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CHOF.FlatAppearance.BorderSize = 0;
            this.CHOF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHOF.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CHOF.ForeColor = System.Drawing.Color.White;
            this.CHOF.Location = new System.Drawing.Point(161, 0);
            this.CHOF.Name = "CHOF";
            this.CHOF.Size = new System.Drawing.Size(160, 100);
            this.CHOF.TabIndex = 26;
            this.CHOF.Text = "Chocolate Coffee";
            this.CHOF.UseVisualStyleBackColor = false;
            // 
            // CHO
            // 
            this.CHO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CHO.FlatAppearance.BorderSize = 0;
            this.CHO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHO.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CHO.ForeColor = System.Drawing.Color.White;
            this.CHO.Location = new System.Drawing.Point(0, 0);
            this.CHO.Name = "CHO";
            this.CHO.Size = new System.Drawing.Size(160, 100);
            this.CHO.TabIndex = 25;
            this.CHO.Text = "Chocolate Latte";
            this.CHO.UseVisualStyleBackColor = false;
            // 
            // Chocolate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.CHOM);
            this.Controls.Add(this.CHOF);
            this.Controls.Add(this.CHO);
            this.Name = "Chocolate";
            this.Size = new System.Drawing.Size(483, 299);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CHOM;
        private System.Windows.Forms.Button CHOF;
        private System.Windows.Forms.Button CHO;
    }
}
