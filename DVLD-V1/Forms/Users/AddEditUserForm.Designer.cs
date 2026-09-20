namespace PersentationLayer.Forms.Users
{
    partial class AddEditUserForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditUserForm));
            this.lbFormMode = new System.Windows.Forms.Label();
            this.tcTakeUserInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnNextTap = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlFindPerson1 = new PersentationLayer.Forms.People.PeopleUserControls.ctrlFindPerson();
            this.tpUserInfo = new System.Windows.Forms.TabPage();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtComfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSaveUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnCloseForm = new Guna.UI2.WinForms.Guna2Button();
            this.epUserErorr = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcTakeUserInfo.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.tpUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUserErorr)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFormMode
            // 
            this.lbFormMode.AutoSize = true;
            this.lbFormMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.lbFormMode.Location = new System.Drawing.Point(585, 9);
            this.lbFormMode.Name = "lbFormMode";
            this.lbFormMode.Size = new System.Drawing.Size(259, 42);
            this.lbFormMode.TabIndex = 0;
            this.lbFormMode.Text = "Add New User";
            // 
            // tcTakeUserInfo
            // 
            this.tcTakeUserInfo.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcTakeUserInfo.Controls.Add(this.tpPersonInfo);
            this.tcTakeUserInfo.Controls.Add(this.tpUserInfo);
            this.tcTakeUserInfo.ItemSize = new System.Drawing.Size(180, 40);
            this.tcTakeUserInfo.Location = new System.Drawing.Point(3, 102);
            this.tcTakeUserInfo.Name = "tcTakeUserInfo";
            this.tcTakeUserInfo.SelectedIndex = 0;
            this.tcTakeUserInfo.Size = new System.Drawing.Size(1394, 646);
            this.tcTakeUserInfo.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcTakeUserInfo.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.tcTakeUserInfo.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcTakeUserInfo.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcTakeUserInfo.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.tcTakeUserInfo.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcTakeUserInfo.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.tcTakeUserInfo.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcTakeUserInfo.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.tcTakeUserInfo.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.tcTakeUserInfo.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcTakeUserInfo.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.tcTakeUserInfo.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcTakeUserInfo.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcTakeUserInfo.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.tcTakeUserInfo.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcTakeUserInfo.TabIndex = 1;
            this.tcTakeUserInfo.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.tpPersonInfo.Controls.Add(this.guna2GroupBox1);
            this.tpPersonInfo.Location = new System.Drawing.Point(184, 4);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(1206, 638);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Personal Info";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.guna2GroupBox1.Controls.Add(this.btnNextTap);
            this.guna2GroupBox1.Controls.Add(this.ctrlFindPerson1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(15, 19);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1176, 613);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "Person Information";
            // 
            // btnNextTap
            // 
            this.btnNextTap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnNextTap.BorderRadius = 5;
            this.btnNextTap.BorderThickness = 1;
            this.btnNextTap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNextTap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNextTap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNextTap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNextTap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnNextTap.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnNextTap.ForeColor = System.Drawing.Color.White;
            this.btnNextTap.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNextTap.Location = new System.Drawing.Point(1026, 527);
            this.btnNextTap.Name = "btnNextTap";
            this.btnNextTap.Size = new System.Drawing.Size(128, 39);
            this.btnNextTap.TabIndex = 3;
            this.btnNextTap.Text = "Next";
            this.btnNextTap.Click += new System.EventHandler(this.btnNextTap_Click);
            // 
            // ctrlFindPerson1
            // 
            this.ctrlFindPerson1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ctrlFindPerson1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ctrlFindPerson1.Location = new System.Drawing.Point(4, 43);
            this.ctrlFindPerson1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlFindPerson1.Name = "ctrlFindPerson1";
            this.ctrlFindPerson1.Size = new System.Drawing.Size(1168, 567);
            this.ctrlFindPerson1.TabIndex = 4;
            // 
            // tpUserInfo
            // 
            this.tpUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.tpUserInfo.Controls.Add(this.guna2PictureBox5);
            this.tpUserInfo.Controls.Add(this.cbStatus);
            this.tpUserInfo.Controls.Add(this.label5);
            this.tpUserInfo.Controls.Add(this.btnBack);
            this.tpUserInfo.Controls.Add(this.guna2PictureBox4);
            this.tpUserInfo.Controls.Add(this.txtComfirmPassword);
            this.tpUserInfo.Controls.Add(this.label4);
            this.tpUserInfo.Controls.Add(this.txtPassword);
            this.tpUserInfo.Controls.Add(this.label3);
            this.tpUserInfo.Controls.Add(this.txtUserName);
            this.tpUserInfo.Controls.Add(this.label2);
            this.tpUserInfo.Controls.Add(this.txtUserID);
            this.tpUserInfo.Controls.Add(this.label1);
            this.tpUserInfo.Controls.Add(this.guna2PictureBox3);
            this.tpUserInfo.Controls.Add(this.guna2PictureBox2);
            this.tpUserInfo.Controls.Add(this.guna2PictureBox1);
            this.tpUserInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tpUserInfo.Location = new System.Drawing.Point(184, 4);
            this.tpUserInfo.Name = "tpUserInfo";
            this.tpUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpUserInfo.Size = new System.Drawing.Size(1206, 638);
            this.tpUserInfo.TabIndex = 1;
            this.tpUserInfo.Text = "User Info";
            // 
            // guna2PictureBox5
            // 
            this.guna2PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox5.Image")));
            this.guna2PictureBox5.ImageRotate = 0F;
            this.guna2PictureBox5.Location = new System.Drawing.Point(368, 358);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.Size = new System.Drawing.Size(41, 39);
            this.guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox5.TabIndex = 15;
            this.guna2PictureBox5.TabStop = false;
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.BorderRadius = 10;
            this.cbStatus.BorderThickness = 2;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(85)))));
            this.cbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.ForeColor = System.Drawing.Color.DarkGray;
            this.cbStatus.ItemHeight = 30;
            this.cbStatus.Items.AddRange(new object[] {
            "Activate",
            "Non Activate"});
            this.cbStatus.Location = new System.Drawing.Point(432, 358);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(181, 36);
            this.cbStatus.StartIndex = 0;
            this.cbStatus.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(173, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Activate User Account ?";
            // 
            // btnBack
            // 
            this.btnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnBack.BorderRadius = 5;
            this.btnBack.BorderThickness = 1;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBack.Location = new System.Drawing.Point(1041, 544);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 39);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(367, 299);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(41, 45);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox4.TabIndex = 11;
            this.guna2PictureBox4.TabStop = false;
            // 
            // txtComfirmPassword
            // 
            this.txtComfirmPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.txtComfirmPassword.BorderRadius = 5;
            this.txtComfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComfirmPassword.DefaultText = "";
            this.txtComfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtComfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtComfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComfirmPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(85)))));
            this.txtComfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.txtComfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtComfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtComfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.txtComfirmPassword.Location = new System.Drawing.Point(432, 304);
            this.txtComfirmPassword.Name = "txtComfirmPassword";
            this.txtComfirmPassword.PasswordChar = '*';
            this.txtComfirmPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.txtComfirmPassword.PlaceholderText = "Confirm Password";
            this.txtComfirmPassword.SelectedText = "";
            this.txtComfirmPassword.Size = new System.Drawing.Size(181, 27);
            this.txtComfirmPassword.TabIndex = 10;
            this.txtComfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateConfirmPassword);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(207, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Confirm Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.txtPassword.BorderRadius = 5;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(85)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.txtPassword.Location = new System.Drawing.Point(432, 246);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(181, 27);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(266, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password :";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.txtUserName.BorderRadius = 5;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(85)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.txtUserName.Location = new System.Drawing.Point(432, 187);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.txtUserName.PlaceholderText = "User Name";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(181, 27);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateUserName);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(259, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "UserName :";
            // 
            // txtUserID
            // 
            this.txtUserID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.txtUserID.BorderRadius = 5;
            this.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserID.DefaultText = "";
            this.txtUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.txtUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.txtUserID.Enabled = false;
            this.txtUserID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(85)))));
            this.txtUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.txtUserID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.txtUserID.Location = new System.Drawing.Point(432, 124);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.txtUserID.PlaceholderText = "User ID";
            this.txtUserID.SelectedText = "";
            this.txtUserID.Size = new System.Drawing.Size(181, 31);
            this.txtUserID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(281, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID :";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(376, 244);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(32, 27);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 8;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(376, 184);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(32, 27);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 5;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(377, 124);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(32, 27);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnSaveUser.BorderRadius = 5;
            this.btnSaveUser.BorderThickness = 1;
            this.btnSaveUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnSaveUser.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSaveUser.ForeColor = System.Drawing.Color.White;
            this.btnSaveUser.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveUser.Image")));
            this.btnSaveUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaveUser.Location = new System.Drawing.Point(1228, 754);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(128, 47);
            this.btnSaveUser.TabIndex = 4;
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnCloseForm.BorderRadius = 5;
            this.btnCloseForm.BorderThickness = 1;
            this.btnCloseForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCloseForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCloseForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnCloseForm.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseForm.Image")));
            this.btnCloseForm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCloseForm.Location = new System.Drawing.Point(1080, 754);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(128, 47);
            this.btnCloseForm.TabIndex = 5;
            this.btnCloseForm.Text = "Close";
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // epUserErorr
            // 
            this.epUserErorr.ContainerControl = this;
            // 
            // AddEditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1411, 814);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.tcTakeUserInfo);
            this.Controls.Add(this.lbFormMode);
            this.Name = "AddEditUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Edit User";
            this.Load += new System.EventHandler(this.AddEditUserForm_Load);
            this.tcTakeUserInfo.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.tpUserInfo.ResumeLayout(false);
            this.tpUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUserErorr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFormMode;
        private Guna.UI2.WinForms.Guna2TabControl tcTakeUserInfo;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabPage tpUserInfo;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btnNextTap;
        private Guna.UI2.WinForms.Guna2Button btnSaveUser;
        private Guna.UI2.WinForms.Guna2Button btnCloseForm;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2TextBox txtComfirmPassword;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtUserID;
        private System.Windows.Forms.Label label1;
        private People.PeopleUserControls.ctrlFindPerson ctrlFindPerson1;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private System.Windows.Forms.ErrorProvider epUserErorr;
    }
}