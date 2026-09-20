namespace PersentationLayer.Forms.Users
{
    partial class UsersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsersList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.csmShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.cmAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtFilterSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFilterOption = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFilterStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Uesrs";
            // 
            // dgvUsersList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUsersList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsersList.ColumnHeadersHeight = 30;
            this.dgvUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUsersList.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsersList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsersList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsersList.Location = new System.Drawing.Point(1, 337);
            this.dgvUsersList.Name = "dgvUsersList";
            this.dgvUsersList.ReadOnly = true;
            this.dgvUsersList.RowHeadersVisible = false;
            this.dgvUsersList.RowTemplate.Height = 35;
            this.dgvUsersList.Size = new System.Drawing.Size(1136, 344);
            this.dgvUsersList.TabIndex = 4;
            this.dgvUsersList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsersList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsersList.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvUsersList.ThemeStyle.ReadOnly = true;
            this.dgvUsersList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsersList.ThemeStyle.RowsStyle.Height = 35;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csmShowDetails,
            this.cmAddNewUser,
            this.cmEditUser,
            this.cmDeleteUser,
            this.cmChangePassword,
            this.toolStripSeparator1,
            this.sendMailToolStripMenuItem,
            this.callPhoneToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(209, 332);
            // 
            // csmShowDetails
            // 
            this.csmShowDetails.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.csmShowDetails.ForeColor = System.Drawing.Color.Black;
            this.csmShowDetails.Image = ((System.Drawing.Image)(resources.GetObject("csmShowDetails.Image")));
            this.csmShowDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.csmShowDetails.Name = "csmShowDetails";
            this.csmShowDetails.Size = new System.Drawing.Size(208, 46);
            this.csmShowDetails.Text = "      Show Details";
            this.csmShowDetails.Click += new System.EventHandler(this.csmShowDetails_Click);
            // 
            // cmAddNewUser
            // 
            this.cmAddNewUser.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmAddNewUser.ForeColor = System.Drawing.Color.Black;
            this.cmAddNewUser.Image = ((System.Drawing.Image)(resources.GetObject("cmAddNewUser.Image")));
            this.cmAddNewUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmAddNewUser.Name = "cmAddNewUser";
            this.cmAddNewUser.Size = new System.Drawing.Size(208, 46);
            this.cmAddNewUser.Text = "      Add New User";
            this.cmAddNewUser.Click += new System.EventHandler(this.cmAddNewUser_Click);
            // 
            // cmEditUser
            // 
            this.cmEditUser.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmEditUser.ForeColor = System.Drawing.Color.Black;
            this.cmEditUser.Image = ((System.Drawing.Image)(resources.GetObject("cmEditUser.Image")));
            this.cmEditUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmEditUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmEditUser.Name = "cmEditUser";
            this.cmEditUser.Padding = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.cmEditUser.Size = new System.Drawing.Size(209, 46);
            this.cmEditUser.Text = "      Edit User";
            this.cmEditUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmEditUser.Click += new System.EventHandler(this.cmEditUser_Click);
            // 
            // cmDeleteUser
            // 
            this.cmDeleteUser.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmDeleteUser.ForeColor = System.Drawing.Color.Black;
            this.cmDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("cmDeleteUser.Image")));
            this.cmDeleteUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmDeleteUser.Name = "cmDeleteUser";
            this.cmDeleteUser.Size = new System.Drawing.Size(208, 46);
            this.cmDeleteUser.Text = "      Delete User";
            this.cmDeleteUser.Click += new System.EventHandler(this.cmDeleteUser_Click);
            // 
            // cmChangePassword
            // 
            this.cmChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("cmChangePassword.Image")));
            this.cmChangePassword.Name = "cmChangePassword";
            this.cmChangePassword.Size = new System.Drawing.Size(208, 46);
            this.cmChangePassword.Text = "Chang Password";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // sendMailToolStripMenuItem
            // 
            this.sendMailToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.sendMailToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sendMailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendMailToolStripMenuItem.Image")));
            this.sendMailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sendMailToolStripMenuItem.Name = "sendMailToolStripMenuItem";
            this.sendMailToolStripMenuItem.Size = new System.Drawing.Size(208, 46);
            this.sendMailToolStripMenuItem.Text = "      Send Email";
            // 
            // callPhoneToolStripMenuItem
            // 
            this.callPhoneToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.callPhoneToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.callPhoneToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("callPhoneToolStripMenuItem.Image")));
            this.callPhoneToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.callPhoneToolStripMenuItem.Name = "callPhoneToolStripMenuItem";
            this.callPhoneToolStripMenuItem.Size = new System.Drawing.Size(208, 46);
            this.callPhoneToolStripMenuItem.Text = "      Call Phone";
            // 
            // lbRecordsCount
            // 
            this.lbRecordsCount.AutoSize = true;
            this.lbRecordsCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbRecordsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lbRecordsCount.Location = new System.Drawing.Point(96, 716);
            this.lbRecordsCount.Name = "lbRecordsCount";
            this.lbRecordsCount.Size = new System.Drawing.Size(17, 19);
            this.lbRecordsCount.TabIndex = 9;
            this.lbRecordsCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(12, 716);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "# Records: ";
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnClose.BorderRadius = 8;
            this.btnClose.BorderThickness = 1;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnClose.Location = new System.Drawing.Point(1004, 697);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 38);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewUser.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewUser.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewUser.Image")));
            this.btnAddNewUser.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddNewUser.Location = new System.Drawing.Point(1060, 267);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(77, 64);
            this.btnAddNewUser.TabIndex = 2;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(371, -28);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(334, 248);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
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
            this.txtFilterSearch.Location = new System.Drawing.Point(286, 283);
            this.txtFilterSearch.Name = "txtFilterSearch";
            this.txtFilterSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.txtFilterSearch.PlaceholderText = "Search here...";
            this.txtFilterSearch.SelectedText = "";
            this.txtFilterSearch.Size = new System.Drawing.Size(220, 36);
            this.txtFilterSearch.TabIndex = 14;
            this.txtFilterSearch.Visible = false;
            this.txtFilterSearch.TextChanged += new System.EventHandler(this.txtFilterSearch_TextChanged);
            this.txtFilterSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterSearch_KeyPress);
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
            this.cbFilterOption.Location = new System.Drawing.Point(80, 283);
            this.cbFilterOption.Name = "cbFilterOption";
            this.cbFilterOption.Size = new System.Drawing.Size(200, 36);
            this.cbFilterOption.StartIndex = 0;
            this.cbFilterOption.TabIndex = 13;
            this.cbFilterOption.SelectedIndexChanged += new System.EventHandler(this.cbFilterOption_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.label3.Location = new System.Drawing.Point(6, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Filter By :";
            // 
            // cbFilterStatus
            // 
            this.cbFilterStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterStatus.BorderRadius = 8;
            this.cbFilterStatus.BorderThickness = 2;
            this.cbFilterStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterStatus.FillColor = System.Drawing.Color.Gainsboro;
            this.cbFilterStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterStatus.ItemHeight = 30;
            this.cbFilterStatus.Items.AddRange(new object[] {
            "All",
            "No",
            "Yes"});
            this.cbFilterStatus.Location = new System.Drawing.Point(300, 283);
            this.cbFilterStatus.Name = "cbFilterStatus";
            this.cbFilterStatus.Size = new System.Drawing.Size(140, 36);
            this.cbFilterStatus.StartIndex = 0;
            this.cbFilterStatus.TabIndex = 15;
            this.cbFilterStatus.Visible = false;
            this.cbFilterStatus.SelectedIndexChanged += new System.EventHandler(this.cbFilterStatus_SelectedIndexChanged);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 751);
            this.Controls.Add(this.cbFilterStatus);
            this.Controls.Add(this.txtFilterSearch);
            this.Controls.Add(this.cbFilterOption);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvUsersList);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnAddNewUser;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsersList;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lbRecordsCount;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem csmShowDetails;
        private System.Windows.Forms.ToolStripMenuItem cmAddNewUser;
        private System.Windows.Forms.ToolStripMenuItem cmEditUser;
        private System.Windows.Forms.ToolStripMenuItem cmDeleteUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sendMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callPhoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmChangePassword;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterOption;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterStatus;
    }
}