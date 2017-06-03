namespace MMPos.Menu.Coffee
{
    partial class RM
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
            this.RM_Hot = new System.Windows.Forms.Button();
            this.RM_Small = new System.Windows.Forms.Button();
            this.RM_Large = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RM_Hot
            // 
            this.RM_Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.RM_Hot.FlatAppearance.BorderSize = 0;
            this.RM_Hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RM_Hot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.RM_Hot.ForeColor = System.Drawing.Color.White;
            this.RM_Hot.Location = new System.Drawing.Point(0, 202);
            this.RM_Hot.Name = "RM_Hot";
            this.RM_Hot.Size = new System.Drawing.Size(480, 100);
            this.RM_Hot.TabIndex = 21;
            this.RM_Hot.Text = "Rich Milk Coffee (Hot)";
            this.RM_Hot.UseVisualStyleBackColor = false;
            this.RM_Hot.Click += new System.EventHandler(this.RM_Hot_Click);
            // 
            // RM_Small
            // 
            this.RM_Small.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.RM_Small.FlatAppearance.BorderSize = 0;
            this.RM_Small.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RM_Small.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.RM_Small.ForeColor = System.Drawing.Color.White;
            this.RM_Small.Location = new System.Drawing.Point(0, 101);
            this.RM_Small.Name = "RM_Small";
            this.RM_Small.Size = new System.Drawing.Size(480, 100);
            this.RM_Small.TabIndex = 20;
            this.RM_Small.Text = "Rich Milk Coffee (S)";
            this.RM_Small.UseVisualStyleBackColor = false;
            this.RM_Small.Click += new System.EventHandler(this.RM_Small_Click);
            // 
            // RM_Large
            // 
            this.RM_Large.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.RM_Large.FlatAppearance.BorderSize = 0;
            this.RM_Large.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RM_Large.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.RM_Large.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RM_Large.Location = new System.Drawing.Point(0, 0);
            this.RM_Large.Name = "RM_Large";
            this.RM_Large.Size = new System.Drawing.Size(480, 100);
            this.RM_Large.TabIndex = 19;
            this.RM_Large.Text = "Rich Milk Coffee (L)";
            this.RM_Large.UseVisualStyleBackColor = false;
            this.RM_Large.Click += new System.EventHandler(this.RM_Large_Click);
            // 
            // RM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.RM_Hot);
            this.Controls.Add(this.RM_Small);
            this.Controls.Add(this.RM_Large);
            this.Name = "RM";
            this.Size = new System.Drawing.Size(483, 299);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RM_Hot;
        private System.Windows.Forms.Button RM_Small;
        private System.Windows.Forms.Button RM_Large;
    }
}
