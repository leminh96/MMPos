namespace MMPos.Menu.Coffee
{
    partial class BL
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
            this.BL_Hot = new System.Windows.Forms.Button();
            this.BL_Small = new System.Windows.Forms.Button();
            this.BL_Large = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BL_Hot
            // 
            this.BL_Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BL_Hot.FlatAppearance.BorderSize = 0;
            this.BL_Hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BL_Hot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BL_Hot.ForeColor = System.Drawing.Color.White;
            this.BL_Hot.Location = new System.Drawing.Point(0, 202);
            this.BL_Hot.Name = "BL_Hot";
            this.BL_Hot.Size = new System.Drawing.Size(480, 100);
            this.BL_Hot.TabIndex = 18;
            this.BL_Hot.Text = "Black Coffee (Hot)";
            this.BL_Hot.UseVisualStyleBackColor = false;
            this.BL_Hot.Click += new System.EventHandler(this.BL_Hot_Click);
            // 
            // BL_Small
            // 
            this.BL_Small.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BL_Small.FlatAppearance.BorderSize = 0;
            this.BL_Small.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BL_Small.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BL_Small.ForeColor = System.Drawing.Color.White;
            this.BL_Small.Location = new System.Drawing.Point(0, 101);
            this.BL_Small.Name = "BL_Small";
            this.BL_Small.Size = new System.Drawing.Size(480, 100);
            this.BL_Small.TabIndex = 17;
            this.BL_Small.Text = "Black Coffee (S)";
            this.BL_Small.UseVisualStyleBackColor = false;
            this.BL_Small.Click += new System.EventHandler(this.BL_Small_Click);
            // 
            // BL_Large
            // 
            this.BL_Large.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BL_Large.FlatAppearance.BorderSize = 0;
            this.BL_Large.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BL_Large.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BL_Large.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BL_Large.Location = new System.Drawing.Point(0, 0);
            this.BL_Large.Name = "BL_Large";
            this.BL_Large.Size = new System.Drawing.Size(480, 100);
            this.BL_Large.TabIndex = 16;
            this.BL_Large.Text = "Black Coffee (L)";
            this.BL_Large.UseVisualStyleBackColor = false;
            this.BL_Large.Click += new System.EventHandler(this.BL_Large_Click);
            // 
            // BL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.BL_Hot);
            this.Controls.Add(this.BL_Small);
            this.Controls.Add(this.BL_Large);
            this.Name = "BL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BL_Hot;
        private System.Windows.Forms.Button BL_Small;
        private System.Windows.Forms.Button BL_Large;
    }
}
