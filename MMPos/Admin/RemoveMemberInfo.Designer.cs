namespace MMPos
{
    partial class RemoveMemberInfo
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
            // OK
            // 
            this.OK.FlatAppearance.BorderSize = 0;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Close
            // 
            this.Close.FlatAppearance.BorderSize = 0;
            // 
            // Member_ListView
            // 
            this.Member_ListView.SelectedIndexChanged += new System.EventHandler(this.Member_ListView_SelectedIndexChanged);
            // 
            // RemoveMemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 733);
            this.Name = "RemoveMemberInfo";
            this.Text = "RemoveMemberInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}