namespace MMPos.Menu.Tea
{
    partial class LOC
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
            this.LOC_Hot = new System.Windows.Forms.Button();
            this.LOC_Small = new System.Windows.Forms.Button();
            this.LOC_Large = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LOC_Hot
            // 
            this.LOC_Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LOC_Hot.FlatAppearance.BorderSize = 0;
            this.LOC_Hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOC_Hot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LOC_Hot.ForeColor = System.Drawing.Color.White;
            this.LOC_Hot.Location = new System.Drawing.Point(0, 202);
            this.LOC_Hot.Name = "LOC_Hot";
            this.LOC_Hot.Size = new System.Drawing.Size(480, 100);
            this.LOC_Hot.TabIndex = 39;
            this.LOC_Hot.Text = "Lychee Lotus Tea (Hot)";
            this.LOC_Hot.UseVisualStyleBackColor = false;
            this.LOC_Hot.Click += new System.EventHandler(this.LOC_Hot_Click);
            // 
            // LOC_Small
            // 
            this.LOC_Small.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LOC_Small.FlatAppearance.BorderSize = 0;
            this.LOC_Small.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOC_Small.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LOC_Small.ForeColor = System.Drawing.Color.White;
            this.LOC_Small.Location = new System.Drawing.Point(0, 101);
            this.LOC_Small.Name = "LOC_Small";
            this.LOC_Small.Size = new System.Drawing.Size(480, 100);
            this.LOC_Small.TabIndex = 38;
            this.LOC_Small.Text = "Lychee Lotus Tea (S)";
            this.LOC_Small.UseVisualStyleBackColor = false;
            this.LOC_Small.Click += new System.EventHandler(this.LOC_Small_Click);
            // 
            // LOC_Large
            // 
            this.LOC_Large.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LOC_Large.FlatAppearance.BorderSize = 0;
            this.LOC_Large.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOC_Large.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LOC_Large.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LOC_Large.Location = new System.Drawing.Point(0, 0);
            this.LOC_Large.Name = "LOC_Large";
            this.LOC_Large.Size = new System.Drawing.Size(480, 100);
            this.LOC_Large.TabIndex = 37;
            this.LOC_Large.Text = "Lychee Lotus Tea (L)";
            this.LOC_Large.UseVisualStyleBackColor = false;
            this.LOC_Large.Click += new System.EventHandler(this.LOC_Large_Click);
            // 
            // LOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.LOC_Hot);
            this.Controls.Add(this.LOC_Small);
            this.Controls.Add(this.LOC_Large);
            this.Name = "LOC";
            this.Size = new System.Drawing.Size(483, 299);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LOC_Hot;
        private System.Windows.Forms.Button LOC_Small;
        private System.Windows.Forms.Button LOC_Large;
    }
}
