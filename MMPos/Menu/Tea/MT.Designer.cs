namespace MMPos.Menu.Tea
{
    partial class MT
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
            this.MT_Hot = new System.Windows.Forms.Button();
            this.MT_Small = new System.Windows.Forms.Button();
            this.MT_Large = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MT_Hot
            // 
            this.MT_Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MT_Hot.FlatAppearance.BorderSize = 0;
            this.MT_Hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MT_Hot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MT_Hot.ForeColor = System.Drawing.Color.White;
            this.MT_Hot.Location = new System.Drawing.Point(0, 202);
            this.MT_Hot.Name = "MT_Hot";
            this.MT_Hot.Size = new System.Drawing.Size(480, 100);
            this.MT_Hot.TabIndex = 42;
            this.MT_Hot.Text = "Black Milk Tea (Hot)";
            this.MT_Hot.UseVisualStyleBackColor = false;
            this.MT_Hot.Click += new System.EventHandler(this.MT_Hot_Click);
            // 
            // MT_Small
            // 
            this.MT_Small.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MT_Small.FlatAppearance.BorderSize = 0;
            this.MT_Small.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MT_Small.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MT_Small.ForeColor = System.Drawing.Color.White;
            this.MT_Small.Location = new System.Drawing.Point(0, 101);
            this.MT_Small.Name = "MT_Small";
            this.MT_Small.Size = new System.Drawing.Size(480, 100);
            this.MT_Small.TabIndex = 41;
            this.MT_Small.Text = "Black Milk Tea (S)";
            this.MT_Small.UseVisualStyleBackColor = false;
            this.MT_Small.Click += new System.EventHandler(this.MT_Small_Click);
            // 
            // MT_Large
            // 
            this.MT_Large.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MT_Large.FlatAppearance.BorderSize = 0;
            this.MT_Large.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MT_Large.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MT_Large.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MT_Large.Location = new System.Drawing.Point(0, 0);
            this.MT_Large.Name = "MT_Large";
            this.MT_Large.Size = new System.Drawing.Size(480, 100);
            this.MT_Large.TabIndex = 40;
            this.MT_Large.Text = "Black Milk Tea (L)";
            this.MT_Large.UseVisualStyleBackColor = false;
            this.MT_Large.Click += new System.EventHandler(this.MT_Large_Click);
            // 
            // MT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.MT_Hot);
            this.Controls.Add(this.MT_Small);
            this.Controls.Add(this.MT_Large);
            this.Name = "MT";
            this.Size = new System.Drawing.Size(483, 299);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MT_Hot;
        private System.Windows.Forms.Button MT_Small;
        private System.Windows.Forms.Button MT_Large;
    }
}
