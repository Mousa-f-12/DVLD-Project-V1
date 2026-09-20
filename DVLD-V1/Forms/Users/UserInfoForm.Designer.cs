namespace PersentationLayer.Forms.Users
{
    partial class UserInfoForm
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
            this.ctrlUserCardInfo1 = new PersentationLayer.Forms.Users.UserControls.ctrlUserCardInfo();
            this.SuspendLayout();
            // 
            // ctrlUserCardInfo1
            // 
            this.ctrlUserCardInfo1.Location = new System.Drawing.Point(-1, 1);
            this.ctrlUserCardInfo1.Name = "ctrlUserCardInfo1";
            this.ctrlUserCardInfo1.Size = new System.Drawing.Size(1026, 567);
            this.ctrlUserCardInfo1.TabIndex = 0;
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 553);
            this.Controls.Add(this.ctrlUserCardInfo1);
            this.Name = "UserInfoForm";
            this.Text = "UserInfoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ctrlUserCardInfo ctrlUserCardInfo1;
    }
}