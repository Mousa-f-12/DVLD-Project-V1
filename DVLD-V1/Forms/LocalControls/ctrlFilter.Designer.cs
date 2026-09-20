namespace PersentationLayer.Forms.LocalControls
{
    partial class ctrlFilter
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
            this.txtFilterSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFilterOption = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFilterSearch
            // 
            this.txtFilterSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.txtFilterSearch.BorderRadius = 8;
            this.txtFilterSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterSearch.DefaultText = "";
            this.txtFilterSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFilterSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.txtFilterSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtFilterSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFilterSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.txtFilterSearch.Location = new System.Drawing.Point(300, 3);
            this.txtFilterSearch.Name = "txtFilterSearch";
            this.txtFilterSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.txtFilterSearch.PlaceholderText = "Search here...";
            this.txtFilterSearch.SelectedText = "";
            this.txtFilterSearch.Size = new System.Drawing.Size(220, 36);
            this.txtFilterSearch.TabIndex = 11;
            this.txtFilterSearch.Visible = false;
            // 
            // cbFilterOption
            // 
            this.cbFilterOption.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterOption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.cbFilterOption.BorderRadius = 8;
            this.cbFilterOption.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterOption.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbFilterOption.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.cbFilterOption.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.cbFilterOption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbFilterOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbFilterOption.ItemHeight = 30;
            this.cbFilterOption.Items.AddRange(new object[] {
            "None",
            "User ID",
            "User Name",
            "Person ID",
            "Full Name",
            "Is Active"});
            this.cbFilterOption.Location = new System.Drawing.Point(94, 3);
            this.cbFilterOption.Name = "cbFilterOption";
            this.cbFilterOption.Size = new System.Drawing.Size(200, 36);
            this.cbFilterOption.StartIndex = 0;
            this.cbFilterOption.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filter By :";
            // 
            // ctrlFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtFilterSearch);
            this.Controls.Add(this.cbFilterOption);
            this.Controls.Add(this.label1);
            this.Name = "ctrlFilter";
            this.Size = new System.Drawing.Size(782, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtFilterSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterOption;
        private System.Windows.Forms.Label label1;
    }
}
