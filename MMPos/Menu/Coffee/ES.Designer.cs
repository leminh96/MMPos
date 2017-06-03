namespace MMPos.Menu.Coffee
{
    partial class ES
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
            this.ES_2 = new System.Windows.Forms.Button();
            this.ES_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ES_2
            // 
            this.ES_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ES_2.FlatAppearance.BorderSize = 0;
            this.ES_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES_2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ES_2.ForeColor = System.Drawing.Color.White;
            this.ES_2.Location = new System.Drawing.Point(0, 101);
            this.ES_2.Name = "ES_2";
            this.ES_2.Size = new System.Drawing.Size(480, 100);
            this.ES_2.TabIndex = 23;
            this.ES_2.Text = "Espresso 2 shots";
            this.ES_2.UseVisualStyleBackColor = false;
            this.ES_2.Click += new System.EventHandler(this.ES_2_Click);
            // 
            // ES_1
            // 
            this.ES_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ES_1.FlatAppearance.BorderSize = 0;
            this.ES_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES_1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ES_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ES_1.Location = new System.Drawing.Point(0, 0);
            this.ES_1.Name = "ES_1";
            this.ES_1.Size = new System.Drawing.Size(480, 100);
            this.ES_1.TabIndex = 22;
            this.ES_1.Text = "Espresso 1 shot";
            this.ES_1.UseVisualStyleBackColor = false;
            this.ES_1.Click += new System.EventHandler(this.ES_1_Click);
            // 
            // ES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.ES_2);
            this.Controls.Add(this.ES_1);
            this.Name = "ES";
            this.Size = new System.Drawing.Size(483, 299);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ES_2;
        private System.Windows.Forms.Button ES_1;
    }
}
