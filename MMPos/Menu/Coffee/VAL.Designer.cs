namespace MMPos.Menu.Coffee
{
    partial class VAL
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
            this.VAL_Hot = new System.Windows.Forms.Button();
            this.VAL_Small = new System.Windows.Forms.Button();
            this.VAL_Large = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VAL_Hot
            // 
            this.VAL_Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.VAL_Hot.FlatAppearance.BorderSize = 0;
            this.VAL_Hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VAL_Hot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.VAL_Hot.ForeColor = System.Drawing.Color.White;
            this.VAL_Hot.Location = new System.Drawing.Point(0, 202);
            this.VAL_Hot.Name = "VAL_Hot";
            this.VAL_Hot.Size = new System.Drawing.Size(480, 100);
            this.VAL_Hot.TabIndex = 33;
            this.VAL_Hot.Text = "Vanilla Latte (Hot)";
            this.VAL_Hot.UseVisualStyleBackColor = false;
            this.VAL_Hot.Click += new System.EventHandler(this.VAL_Hot_Click);
            // 
            // VAL_Small
            // 
            this.VAL_Small.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.VAL_Small.FlatAppearance.BorderSize = 0;
            this.VAL_Small.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VAL_Small.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.VAL_Small.ForeColor = System.Drawing.Color.White;
            this.VAL_Small.Location = new System.Drawing.Point(0, 101);
            this.VAL_Small.Name = "VAL_Small";
            this.VAL_Small.Size = new System.Drawing.Size(480, 100);
            this.VAL_Small.TabIndex = 32;
            this.VAL_Small.Text = "Vanilla Latte (S)";
            this.VAL_Small.UseVisualStyleBackColor = false;
            this.VAL_Small.Click += new System.EventHandler(this.VAL_Small_Click);
            // 
            // VAL_Large
            // 
            this.VAL_Large.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.VAL_Large.FlatAppearance.BorderSize = 0;
            this.VAL_Large.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VAL_Large.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.VAL_Large.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.VAL_Large.Location = new System.Drawing.Point(0, 0);
            this.VAL_Large.Name = "VAL_Large";
            this.VAL_Large.Size = new System.Drawing.Size(480, 100);
            this.VAL_Large.TabIndex = 31;
            this.VAL_Large.Text = "Vanilla Latte (L)";
            this.VAL_Large.UseVisualStyleBackColor = false;
            this.VAL_Large.Click += new System.EventHandler(this.VAL_Large_Click);
            // 
            // VAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.VAL_Hot);
            this.Controls.Add(this.VAL_Small);
            this.Controls.Add(this.VAL_Large);
            this.Name = "VAL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VAL_Hot;
        private System.Windows.Forms.Button VAL_Small;
        private System.Windows.Forms.Button VAL_Large;
    }
}
