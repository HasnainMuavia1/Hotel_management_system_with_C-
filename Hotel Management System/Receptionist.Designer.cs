namespace Hotel_Management_System
{
    partial class Receptionist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receptionist));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.childpanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.grid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.namepanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.Housekeeping = new FontAwesome.Sharp.IconButton();
            this.Logout = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.Availability = new FontAwesome.Sharp.IconButton();
            this.btnBookings = new FontAwesome.Sharp.IconButton();
            this.navbar = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.User = new FontAwesome.Sharp.IconButton();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.childpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.namepanel.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // childpanel
            // 
            this.childpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.childpanel.BackgroundColor = System.Drawing.Color.White;
            this.childpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("childpanel.BackgroundImage")));
            this.childpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.childpanel.BorderColor = System.Drawing.Color.Transparent;
            this.childpanel.BorderRadius = 3;
            this.childpanel.BorderThickness = 1;
            this.childpanel.Controls.Add(this.grid);
            this.childpanel.Controls.Add(this.namepanel);
            this.childpanel.Location = new System.Drawing.Point(209, 63);
            this.childpanel.Name = "childpanel";
            this.childpanel.ShowBorders = true;
            this.childpanel.Size = new System.Drawing.Size(602, 483);
            this.childpanel.TabIndex = 6;
            this.childpanel.Click += new System.EventHandler(this.childpanel_Click);
            // 
            // grid
            // 
            this.grid.AllowCustomTheming = false;
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(226)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(111)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid.ColumnHeadersHeight = 40;
            this.grid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(226)))), ((int)(((byte)(199)))));
            this.grid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.grid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grid.CurrentTheme.BackColor = System.Drawing.Color.ForestGreen;
            this.grid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.grid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.ForestGreen;
            this.grid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.grid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(111)))), ((int)(((byte)(27)))));
            this.grid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grid.CurrentTheme.Name = null;
            this.grid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            this.grid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.grid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle7;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.grid.HeaderBackColor = System.Drawing.Color.ForestGreen;
            this.grid.HeaderBgColor = System.Drawing.Color.Empty;
            this.grid.HeaderForeColor = System.Drawing.Color.White;
            this.grid.Location = new System.Drawing.Point(3, 76);
            this.grid.Name = "grid";
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid.RowTemplate.Height = 40;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(596, 404);
            this.grid.TabIndex = 14;
            this.grid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.ForestGreen;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            this.grid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellEndEdit);
            // 
            // namepanel
            // 
            this.namepanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namepanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.namepanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("namepanel.BackgroundImage")));
            this.namepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.namepanel.BorderColor = System.Drawing.Color.Transparent;
            this.namepanel.BorderRadius = 3;
            this.namepanel.BorderThickness = 1;
            this.namepanel.Controls.Add(this.iconButton2);
            this.namepanel.Controls.Add(this.iconButton1);
            this.namepanel.Controls.Add(this.bunifuLabel6);
            this.namepanel.Controls.Add(this.bunifuLabel7);
            this.namepanel.Location = new System.Drawing.Point(0, 2);
            this.namepanel.Name = "namepanel";
            this.namepanel.ShowBorders = true;
            this.namepanel.Size = new System.Drawing.Size(608, 73);
            this.namepanel.TabIndex = 13;
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(156)))), ((int)(((byte)(49)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 15;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(425, 19);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(83, 38);
            this.iconButton2.TabIndex = 11;
            this.iconButton2.Text = "Delete ";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(156)))), ((int)(((byte)(49)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 15;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(514, 19);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(83, 38);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.Text = "Add";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuLabel6.Location = new System.Drawing.Point(10, 35);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(0, 0);
            this.bunifuLabel6.TabIndex = 1;
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AllowParentOverrides = false;
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.CursorType = null;
            this.bunifuLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuLabel7.Location = new System.Drawing.Point(9, 19);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(44, 15);
            this.bunifuLabel7.TabIndex = 0;
            this.bunifuLabel7.Text = "Booking";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 0;
            this.bunifuPanel2.Controls.Add(this.Housekeeping);
            this.bunifuPanel2.Controls.Add(this.Logout);
            this.bunifuPanel2.Controls.Add(this.label2);
            this.bunifuPanel2.Controls.Add(this.label1);
            this.bunifuPanel2.Controls.Add(this.bunifuLabel5);
            this.bunifuPanel2.Controls.Add(this.Availability);
            this.bunifuPanel2.Controls.Add(this.btnBookings);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 65);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(209, 516);
            this.bunifuPanel2.TabIndex = 5;
            // 
            // Housekeeping
            // 
            this.Housekeeping.BackColor = System.Drawing.Color.Transparent;
            this.Housekeeping.FlatAppearance.BorderSize = 0;
            this.Housekeeping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Housekeeping.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Housekeeping.ForeColor = System.Drawing.Color.DimGray;
            this.Housekeeping.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.Housekeeping.IconColor = System.Drawing.Color.DimGray;
            this.Housekeeping.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Housekeeping.IconSize = 25;
            this.Housekeeping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Housekeeping.Location = new System.Drawing.Point(0, 123);
            this.Housekeeping.Name = "Housekeeping";
            this.Housekeeping.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Housekeeping.Size = new System.Drawing.Size(200, 38);
            this.Housekeeping.TabIndex = 15;
            this.Housekeeping.Text = "   Housekeeping Task";
            this.Housekeeping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Housekeeping.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Housekeeping.UseVisualStyleBackColor = false;
            this.Housekeeping.Click += new System.EventHandler(this.Housekeeping_Click);
            this.Housekeeping.Leave += new System.EventHandler(this.Housekeeping_Leave);
            // 
            // Logout
            // 
            this.Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.DimGray;
            this.Logout.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.Logout.IconColor = System.Drawing.Color.DimGray;
            this.Logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Logout.IconSize = 25;
            this.Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout.Location = new System.Drawing.Point(3, 384);
            this.Logout.Name = "Logout";
            this.Logout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Logout.Size = new System.Drawing.Size(200, 38);
            this.Logout.TabIndex = 14;
            this.Logout.Text = "   Logout";
            this.Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(18, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "All rights reserved";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(18, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "@Hasnain Muavia 2023\r\n";
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(156)))), ((int)(((byte)(49)))));
            this.bunifuLabel5.Location = new System.Drawing.Point(20, 428);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(109, 17);
            this.bunifuLabel5.TabIndex = 11;
            this.bunifuLabel5.Text = "The Hotel Deluna";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Availability
            // 
            this.Availability.BackColor = System.Drawing.Color.Transparent;
            this.Availability.FlatAppearance.BorderSize = 0;
            this.Availability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Availability.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Availability.ForeColor = System.Drawing.Color.DimGray;
            this.Availability.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.Availability.IconColor = System.Drawing.Color.DimGray;
            this.Availability.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Availability.IconSize = 25;
            this.Availability.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Availability.Location = new System.Drawing.Point(0, 79);
            this.Availability.Name = "Availability";
            this.Availability.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Availability.Size = new System.Drawing.Size(200, 38);
            this.Availability.TabIndex = 10;
            this.Availability.Text = "   Room Availability";
            this.Availability.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Availability.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Availability.UseVisualStyleBackColor = false;
            this.Availability.Click += new System.EventHandler(this.Availability_Click);
            this.Availability.Leave += new System.EventHandler(this.Availability_Leave);
            // 
            // btnBookings
            // 
            this.btnBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(156)))), ((int)(((byte)(49)))));
            this.btnBookings.FlatAppearance.BorderSize = 0;
            this.btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookings.ForeColor = System.Drawing.Color.Transparent;
            this.btnBookings.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.btnBookings.IconColor = System.Drawing.Color.White;
            this.btnBookings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBookings.IconSize = 25;
            this.btnBookings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookings.Location = new System.Drawing.Point(0, 35);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnBookings.Size = new System.Drawing.Size(200, 38);
            this.btnBookings.TabIndex = 9;
            this.btnBookings.Text = "   Bookings";
            this.btnBookings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookings.UseVisualStyleBackColor = false;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            this.btnBookings.Leave += new System.EventHandler(this.btnBookings_Leave);
            // 
            // navbar
            // 
            this.navbar.BackgroundColor = System.Drawing.Color.White;
            this.navbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("navbar.BackgroundImage")));
            this.navbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.navbar.BorderColor = System.Drawing.Color.Transparent;
            this.navbar.BorderRadius = 3;
            this.navbar.BorderThickness = 1;
            this.navbar.Controls.Add(this.pictureBox1);
            this.navbar.Controls.Add(this.User);
            this.navbar.Controls.Add(this.bunifuPictureBox1);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.ShowBorders = true;
            this.navbar.Size = new System.Drawing.Size(838, 65);
            this.navbar.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // User
            // 
            this.User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.User.BackColor = System.Drawing.Color.Transparent;
            this.User.Cursor = System.Windows.Forms.Cursors.No;
            this.User.FlatAppearance.BorderSize = 0;
            this.User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.Black;
            this.User.IconChar = FontAwesome.Sharp.IconChar.User;
            this.User.IconColor = System.Drawing.Color.Black;
            this.User.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.User.IconSize = 25;
            this.User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.User.Location = new System.Drawing.Point(696, 12);
            this.User.Name = "User";
            this.User.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.User.Size = new System.Drawing.Size(130, 38);
            this.User.TabIndex = 10;
            this.User.Text = "   ";
            this.User.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.User.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.User.UseVisualStyleBackColor = false;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuPictureBox1.BorderRadius = 57;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(-5, -25);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(114, 114);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(838, 581);
            this.Controls.Add(this.childpanel);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.navbar);
            this.Name = "Receptionist";
            this.Text = "Receptionist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Receptionist_FormClosing);
            this.Load += new System.EventHandler(this.Receptionist_Load);
            this.childpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.namepanel.ResumeLayout(false);
            this.namepanel.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel navbar;
        private FontAwesome.Sharp.IconButton User;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private FontAwesome.Sharp.IconButton Logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private FontAwesome.Sharp.IconButton Availability;
        private FontAwesome.Sharp.IconButton btnBookings;
        private Bunifu.UI.WinForms.BunifuPanel childpanel;
        private Bunifu.UI.WinForms.BunifuPanel namepanel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Bunifu.UI.WinForms.BunifuDataGridView grid;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton Housekeeping;
    }
}