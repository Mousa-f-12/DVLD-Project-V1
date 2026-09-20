namespace PersentationLayer.Forms.Tests
{
    partial class ManageApplicationTypesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageApplicationTypesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dgvApplicationTypesList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editApplicationTypeInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRecordsCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbApplicationTypesListCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypesList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(260, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(280, 160);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // dgvApplicationTypesList
            // 
            this.dgvApplicationTypesList.AllowUserToAddRows = false;
            this.dgvApplicationTypesList.AllowUserToDeleteRows = false;
            this.dgvApplicationTypesList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(75)))));
            this.dgvApplicationTypesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicationTypesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApplicationTypesList.ColumnHeadersHeight = 40;
            this.dgvApplicationTypesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvApplicationTypesList.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApplicationTypesList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvApplicationTypesList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.dgvApplicationTypesList.Location = new System.Drawing.Point(16, 240);
            this.dgvApplicationTypesList.Name = "dgvApplicationTypesList";
            this.dgvApplicationTypesList.ReadOnly = true;
            this.dgvApplicationTypesList.RowHeadersVisible = false;
            this.dgvApplicationTypesList.RowTemplate.Height = 35;
            this.dgvApplicationTypesList.Size = new System.Drawing.Size(768, 280);
            this.dgvApplicationTypesList.TabIndex = 1;
            this.dgvApplicationTypesList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.dgvApplicationTypesList.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dgvApplicationTypesList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.dgvApplicationTypesList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.dgvApplicationTypesList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(75)))));
            this.dgvApplicationTypesList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.dgvApplicationTypesList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.dgvApplicationTypesList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dgvApplicationTypesList.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvApplicationTypesList.ThemeStyle.ReadOnly = true;
            this.dgvApplicationTypesList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dgvApplicationTypesList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.dgvApplicationTypesList.ThemeStyle.RowsStyle.Height = 35;
            this.dgvApplicationTypesList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.dgvApplicationTypesList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(75)))));
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editApplicationTypeInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 48);
            // 
            // editApplicationTypeInfoToolStripMenuItem
            // 
            this.editApplicationTypeInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editApplicationTypeInfoToolStripMenuItem.Image")));
            this.editApplicationTypeInfoToolStripMenuItem.Name = "editApplicationTypeInfoToolStripMenuItem";
            this.editApplicationTypeInfoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.editApplicationTypeInfoToolStripMenuItem.Text = "Edit Application Type";
            this.editApplicationTypeInfoToolStripMenuItem.Click += new System.EventHandler(this.editApplicationTypeInfoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(12, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Application Types";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnClose.BorderRadius = 8;
            this.btnClose.BorderThickness = 1;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnClose.Location = new System.Drawing.Point(664, 536);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 38);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(-464, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "# Records: ";
            // 
            // lbRecordsCount
            // 
            this.lbRecordsCount.AutoSize = true;
            this.lbRecordsCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbRecordsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.lbRecordsCount.Location = new System.Drawing.Point(95, 561);
            this.lbRecordsCount.Name = "lbRecordsCount";
            this.lbRecordsCount.Size = new System.Drawing.Size(17, 19);
            this.lbRecordsCount.TabIndex = 12;
            this.lbRecordsCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(16, 545);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "# Records: ";
            // 
            // lbApplicationTypesListCount
            // 
            this.lbApplicationTypesListCount.AutoSize = true;
            this.lbApplicationTypesListCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbApplicationTypesListCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.lbApplicationTypesListCount.Location = new System.Drawing.Point(96, 545);
            this.lbApplicationTypesListCount.Name = "lbApplicationTypesListCount";
            this.lbApplicationTypesListCount.Size = new System.Drawing.Size(17, 19);
            this.lbApplicationTypesListCount.TabIndex = 12;
            this.lbApplicationTypesListCount.Text = "0";
            // 
            // ManageApplicationTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.lbApplicationTypesListCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvApplicationTypesList);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageApplicationTypesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Application Types";
            this.Load += new System.EventHandler(this.ManageApplicationTypesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypesList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvApplicationTypesList;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lbRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRecordCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbApplicationTypesListCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editApplicationTypeInfoToolStripMenuItem;
    }
}