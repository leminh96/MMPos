namespace MMPos.Menu.Chocolate
{
    partial class CHOF
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
            this.CHOF_Hot = new System.Windows.Forms.Button();
            this.CHOF_Small = new System.Windows.Forms.Button();
            this.CHOF_Large = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CHOF_Hot
            // 
            this.CHOF_Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CHOF_Hot.FlatAppearance.BorderSize = 0;
            this.CHOF_Hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHOF_Hot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CHOF_Hot.ForeColor = System.Drawing.Color.White;
            this.CHOF_Hot.Location = new System.Drawing.Point(0, 202);
            this.CHOF_Hot.Name = "CHOF_Hot";
            this.CHOF_Hot.Size = new System.Drawing.Size(480, 100);
            this.CHOF_Hot.TabIndex = 51;
            this.CHOF_Hot.Text = "Chocolate Coffee (Hot)";
            this.CHOF_Hot.UseVisualStyleBackColor = false;
            this.CHOF_Hot.Click += new System.EventHandler(this.CHOF_Hot_Click);
            // 
            // CHOF_Small
            // 
            this.CHOF_Small.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CHOF_Small.FlatAppearance.BorderSize = 0;
            this.CHOF_Small.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHOF_Small.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CHOF_Small.ForeColor = System.Drawing.Color.White;
            this.CHOF_Small.Location = new System.Drawing.Point(0, 101);
            this.CHOF_Small.Name = "CHOF_Small";
            this.CHOF_Small.Size = new System.Drawing.Size(480, 100);
            this.CHOF_Small.TabIndex = 50;
            this.CHOF_Small.Text = "Chocolate Coffee (S)";
            this.CHOF_Small.UseVisualStyleBackColor = false;
            this.CHOF_Small.Click += new System.EventHandler(this.CHOF_Small_Click);
            // 
            // CHOF_Large
            // 
            this.CHOF_Large.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CHOF_Large.FlatAppearance.BorderSize = 0;
            this.CHOF_Large.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHOF_Large.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CHOF_Large.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CHOF_Large.Location = new System.Drawing.Point(0, 0);
            this.CHOF_Large.Name = "CHOF_Large";
            this.CHOF_Large.Size = new System.Drawing.Size(480, 100);
            this.CHOF_Large.TabIndex = 49;
            this.CHOF_Large.Text = "Chocolate Coffee (L)";
            this.CHOF_Large.UseVisualStyleBackColor = false;
            this.CHOF_Large.Click += new System.EventHandler(this.CHOF_Large_Click);
            // 
            // CHOF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.CHOF_Hot);
            this.Controls.Add(this.CHOF_Small);
            this.Controls.Add(this.CHOF_Large);
            this.Name = "CHOF";
            this.Size = new System.Drawing.Size(483, 299);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CHOF_Hot;
        private System.Windows.Forms.Button CHOF_Small;
        private System.Windows.Forms.Button CHOF_Large;
    }
}
