namespace MMPos.Menu.Tea
{
    partial class OM
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
            this.OM_Hot = new System.Windows.Forms.Button();
            this.OM_Small = new System.Windows.Forms.Button();
            this.OM_Large = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OM_Hot
            // 
            this.OM_Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.OM_Hot.FlatAppearance.BorderSize = 0;
            this.OM_Hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OM_Hot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.OM_Hot.ForeColor = System.Drawing.Color.White;
            this.OM_Hot.Location = new System.Drawing.Point(0, 202);
            this.OM_Hot.Name = "OM_Hot";
            this.OM_Hot.Size = new System.Drawing.Size(480, 100);
            this.OM_Hot.TabIndex = 30;
            this.OM_Hot.Text = "Olong Milk Tea (Hot)";
            this.OM_Hot.UseVisualStyleBackColor = false;
            this.OM_Hot.Click += new System.EventHandler(this.OM_Hot_Click);
            // 
            // OM_Small
            // 
            this.OM_Small.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.OM_Small.FlatAppearance.BorderSize = 0;
            this.OM_Small.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OM_Small.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.OM_Small.ForeColor = System.Drawing.Color.White;
            this.OM_Small.Location = new System.Drawing.Point(0, 101);
            this.OM_Small.Name = "OM_Small";
            this.OM_Small.Size = new System.Drawing.Size(480, 100);
            this.OM_Small.TabIndex = 29;
            this.OM_Small.Text = "Olong Milk Tea (S)";
            this.OM_Small.UseVisualStyleBackColor = false;
            this.OM_Small.Click += new System.EventHandler(this.OM_Small_Click);
            // 
            // OM_Large
            // 
            this.OM_Large.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.OM_Large.FlatAppearance.BorderSize = 0;
            this.OM_Large.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OM_Large.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.OM_Large.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OM_Large.Location = new System.Drawing.Point(0, 0);
            this.OM_Large.Name = "OM_Large";
            this.OM_Large.Size = new System.Drawing.Size(480, 100);
            this.OM_Large.TabIndex = 28;
            this.OM_Large.Text = "Olong Milk Tea (L)";
            this.OM_Large.UseVisualStyleBackColor = false;
            this.OM_Large.Click += new System.EventHandler(this.OM_Large_Click);
            // 
            // OM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.OM_Hot);
            this.Controls.Add(this.OM_Small);
            this.Controls.Add(this.OM_Large);
            this.Name = "OM";
            this.Size = new System.Drawing.Size(483, 299);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OM_Hot;
        private System.Windows.Forms.Button OM_Small;
        private System.Windows.Forms.Button OM_Large;
    }
}
