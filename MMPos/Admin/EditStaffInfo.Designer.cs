namespace MMPos
{
    partial class EditStaffInfo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.FlatAppearance.BorderSize = 0;
            // 
            // OK
            // 
            this.OK.FlatAppearance.BorderSize = 0;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Staff_ListView
            // 
            this.Staff_ListView.SelectedIndexChanged += new System.EventHandler(this.Staff_ListView_SelectedIndexChanged);
            // 
            // EditStaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 733);
            this.Name = "EditStaffInfo";
            this.Text = "EditStaffInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}