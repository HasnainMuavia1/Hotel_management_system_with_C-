namespace Hotel_Management_System
{
    partial class Customer
    {
        public static Customer Instance;
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
            Instance = this;
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.childpanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.namepanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel9 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.Search = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.child = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.adult = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.Check_out = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.Check_in = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btncontact = new FontAwesome.Sharp.IconButton();
            this.btnbook = new FontAwesome.Sharp.IconButton();
            this.btnroom = new FontAwesome.Sharp.IconButton();
            this.navbar = new Bunifu.UI.WinForms.BunifuPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.childpanel.SuspendLayout();
            this.namepanel.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.childpanel.Controls.Add(this.namepanel);
            this.childpanel.Controls.Add(this.Search);
            this.childpanel.Controls.Add(this.bunifuLabel4);
            this.childpanel.Controls.Add(this.child);
            this.childpanel.Controls.Add(this.bunifuLabel3);
            this.childpanel.Controls.Add(this.adult);
            this.childpanel.Controls.Add(this.bunifuLabel2);
            this.childpanel.Controls.Add(this.Check_out);
            this.childpanel.Controls.Add(this.bunifuLabel1);
            this.childpanel.Controls.Add(this.Check_in);
            this.childpanel.Location = new System.Drawing.Point(206, 65);
            this.childpanel.Name = "childpanel";
            this.childpanel.ShowBorders = true;
            this.childpanel.Size = new System.Drawing.Size(602, 483);
            this.childpanel.TabIndex = 2;
            this.childpanel.Click += new System.EventHandler(this.childpanel_Click);
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
            this.namepanel.Controls.Add(this.bunifuLabel9);
            this.namepanel.Controls.Add(this.bunifuLabel8);
            this.namepanel.Location = new System.Drawing.Point(1, 2);
            this.namepanel.Name = "namepanel";
            this.namepanel.ShowBorders = true;
            this.namepanel.Size = new System.Drawing.Size(608, 73);
            this.namepanel.TabIndex = 11;
            this.namepanel.Click += new System.EventHandler(this.namepanel_Click);
            // 
            // bunifuLabel9
            // 
            this.bunifuLabel9.AllowParentOverrides = false;
            this.bunifuLabel9.AutoEllipsis = false;
            this.bunifuLabel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel9.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuLabel9.Location = new System.Drawing.Point(10, 35);
            this.bunifuLabel9.Name = "bunifuLabel9";
            this.bunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel9.Size = new System.Drawing.Size(198, 25);
            this.bunifuLabel9.TabIndex = 1;
            this.bunifuLabel9.Text = "Reserve Your Booking";
            this.bunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel8
            // 
            this.bunifuLabel8.AllowParentOverrides = false;
            this.bunifuLabel8.AutoEllipsis = false;
            this.bunifuLabel8.CursorType = null;
            this.bunifuLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuLabel8.Location = new System.Drawing.Point(9, 19);
            this.bunifuLabel8.Name = "bunifuLabel8";
            this.bunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel8.Size = new System.Drawing.Size(55, 15);
            this.bunifuLabel8.TabIndex = 0;
            this.bunifuLabel8.Text = "Book Now";
            this.bunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Search
            // 
            this.Search.AllowAnimations = true;
            this.Search.AllowMouseEffects = true;
            this.Search.AllowToggling = false;
            this.Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Search.AnimationSpeed = 200;
            this.Search.AutoGenerateColors = false;
            this.Search.AutoRoundBorders = false;
            this.Search.AutoSizeLeftIcon = true;
            this.Search.AutoSizeRightIcon = true;
            this.Search.BackColor = System.Drawing.Color.Transparent;
            this.Search.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(156)))), ((int)(((byte)(49)))));
            this.Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Search.BackgroundImage")));
            this.Search.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Search.ButtonText = "Search";
            this.Search.ButtonTextMarginLeft = 0;
            this.Search.ColorContrastOnClick = 45;
            this.Search.ColorContrastOnHover = 45;
            this.Search.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Search.CustomizableEdges = borderEdges1;
            this.Search.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Search.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Search.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Search.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Search.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Search.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Search.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Search.IconMarginLeft = 11;
            this.Search.IconPadding = 10;
            this.Search.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Search.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Search.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Search.IconSize = 25;
            this.Search.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.Search.IdleBorderRadius = 30;
            this.Search.IdleBorderThickness = 1;
            this.Search.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(156)))), ((int)(((byte)(49)))));
            this.Search.IdleIconLeftImage = null;
            this.Search.IdleIconRightImage = null;
            this.Search.IndicateFocus = false;
            this.Search.Location = new System.Drawing.Point(209, 335);
            this.Search.Name = "Search";
            this.Search.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Search.OnDisabledState.BorderRadius = 30;
            this.Search.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Search.OnDisabledState.BorderThickness = 1;
            this.Search.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Search.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Search.OnDisabledState.IconLeftImage = null;
            this.Search.OnDisabledState.IconRightImage = null;
            this.Search.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Search.onHoverState.BorderRadius = 30;
            this.Search.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Search.onHoverState.BorderThickness = 1;
            this.Search.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Search.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Search.onHoverState.IconLeftImage = null;
            this.Search.onHoverState.IconRightImage = null;
            this.Search.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Search.OnIdleState.BorderRadius = 30;
            this.Search.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Search.OnIdleState.BorderThickness = 1;
            this.Search.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(156)))), ((int)(((byte)(49)))));
            this.Search.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Search.OnIdleState.IconLeftImage = null;
            this.Search.OnIdleState.IconRightImage = null;
            this.Search.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Search.OnPressedState.BorderRadius = 30;
            this.Search.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Search.OnPressedState.BorderThickness = 1;
            this.Search.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Search.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Search.OnPressedState.IconLeftImage = null;
            this.Search.OnPressedState.IconRightImage = null;
            this.Search.Size = new System.Drawing.Size(150, 39);
            this.Search.TabIndex = 9;
            this.Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Search.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Search.TextMarginLeft = 0;
            this.Search.TextPadding = new System.Windows.Forms.Padding(0);
            this.Search.UseDefaultRadiusAndThickness = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel4.Location = new System.Drawing.Point(327, 262);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(56, 20);
            this.bunifuLabel4.TabIndex = 8;
            this.bunifuLabel4.Text = "children";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // child
            // 
            this.child.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.child.BackColor = System.Drawing.Color.Transparent;
            this.child.BackgroundColor = System.Drawing.Color.White;
            this.child.BorderColor = System.Drawing.Color.DimGray;
            this.child.BorderRadius = 10;
            this.child.Color = System.Drawing.Color.DimGray;
            this.child.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.child.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.child.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.child.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.child.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.child.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.child.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.child.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.child.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.child.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.child.FillDropDown = true;
            this.child.FillIndicator = false;
            this.child.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.child.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.child.ForeColor = System.Drawing.Color.Black;
            this.child.FormattingEnabled = true;
            this.child.Icon = null;
            this.child.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.child.IndicatorColor = System.Drawing.Color.Gray;
            this.child.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.child.ItemBackColor = System.Drawing.Color.White;
            this.child.ItemBorderColor = System.Drawing.Color.White;
            this.child.ItemForeColor = System.Drawing.Color.Black;
            this.child.ItemHeight = 26;
            this.child.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.child.ItemHighLightForeColor = System.Drawing.Color.White;
            this.child.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.child.ItemTopMargin = 3;
            this.child.Location = new System.Drawing.Point(325, 287);
            this.child.Name = "child";
            this.child.Size = new System.Drawing.Size(70, 32);
            this.child.TabIndex = 7;
            this.child.Text = "0";
            this.child.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.child.TextLeftMargin = 5;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel3.Location = new System.Drawing.Point(177, 262);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(46, 20);
            this.bunifuLabel3.TabIndex = 6;
            this.bunifuLabel3.Text = "Adults";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // adult
            // 
            this.adult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adult.BackColor = System.Drawing.Color.Transparent;
            this.adult.BackgroundColor = System.Drawing.Color.White;
            this.adult.BorderColor = System.Drawing.Color.DimGray;
            this.adult.BorderRadius = 10;
            this.adult.Color = System.Drawing.Color.DimGray;
            this.adult.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.adult.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.adult.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.adult.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.adult.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.adult.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.adult.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.adult.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.adult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adult.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.adult.FillDropDown = true;
            this.adult.FillIndicator = false;
            this.adult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adult.ForeColor = System.Drawing.Color.Black;
            this.adult.FormattingEnabled = true;
            this.adult.Icon = null;
            this.adult.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.adult.IndicatorColor = System.Drawing.Color.Gray;
            this.adult.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.adult.ItemBackColor = System.Drawing.Color.White;
            this.adult.ItemBorderColor = System.Drawing.Color.White;
            this.adult.ItemForeColor = System.Drawing.Color.Black;
            this.adult.ItemHeight = 26;
            this.adult.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.adult.ItemHighLightForeColor = System.Drawing.Color.White;
            this.adult.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.adult.ItemTopMargin = 3;
            this.adult.Location = new System.Drawing.Point(176, 287);
            this.adult.Name = "adult";
            this.adult.Size = new System.Drawing.Size(70, 32);
            this.adult.TabIndex = 5;
            this.adult.Text = "1";
            this.adult.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.adult.TextLeftMargin = 5;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.Location = new System.Drawing.Point(177, 203);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(71, 20);
            this.bunifuLabel2.TabIndex = 4;
            this.bunifuLabel2.Text = "Check-out";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Check_out
            // 
            this.Check_out.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Check_out.BackColor = System.Drawing.Color.White;
            this.Check_out.BorderRadius = 7;
            this.Check_out.Color = System.Drawing.Color.Gray;
            this.Check_out.CustomFormat = "yyyy-MM-dd";
            this.Check_out.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.Check_out.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.Check_out.DisabledColor = System.Drawing.Color.Gray;
            this.Check_out.DisplayWeekNumbers = false;
            this.Check_out.DPHeight = 0;
            this.Check_out.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Check_out.FillDatePicker = false;
            this.Check_out.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Check_out.ForeColor = System.Drawing.Color.Black;
            this.Check_out.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Check_out.Icon = ((System.Drawing.Image)(resources.GetObject("Check_out.Icon")));
            this.Check_out.IconColor = System.Drawing.Color.Black;
            this.Check_out.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.Check_out.LeftTextMargin = 5;
            this.Check_out.Location = new System.Drawing.Point(177, 228);
            this.Check_out.MinimumSize = new System.Drawing.Size(4, 32);
            this.Check_out.Name = "Check_out";
            this.Check_out.Size = new System.Drawing.Size(220, 32);
            this.Check_out.TabIndex = 3;
            this.Check_out.Value = new System.DateTime(2023, 6, 4, 0, 0, 0, 0);
            this.Check_out.ValueChanged += new System.EventHandler(this.Check_out_ValueChanged);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(177, 141);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(60, 20);
            this.bunifuLabel1.TabIndex = 2;
            this.bunifuLabel1.Text = "Check-in";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // Check_in
            // 
            this.Check_in.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Check_in.BackColor = System.Drawing.Color.White;
            this.Check_in.BorderRadius = 7;
            this.Check_in.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Check_in.CalendarTitleBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Check_in.Color = System.Drawing.Color.Gray;
            this.Check_in.CustomFormat = "yyyy-MM-dd";
            this.Check_in.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.Check_in.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.Check_in.DisabledColor = System.Drawing.Color.Gray;
            this.Check_in.DisplayWeekNumbers = false;
            this.Check_in.DPHeight = 0;
            this.Check_in.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Check_in.FillDatePicker = false;
            this.Check_in.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Check_in.ForeColor = System.Drawing.Color.Black;
            this.Check_in.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Check_in.Icon = ((System.Drawing.Image)(resources.GetObject("Check_in.Icon")));
            this.Check_in.IconColor = System.Drawing.Color.Black;
            this.Check_in.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.Check_in.LeftTextMargin = 5;
            this.Check_in.Location = new System.Drawing.Point(175, 166);
            this.Check_in.MinimumSize = new System.Drawing.Size(4, 32);
            this.Check_in.Name = "Check_in";
            this.Check_in.Size = new System.Drawing.Size(220, 32);
            this.Check_in.TabIndex = 1;
            this.Check_in.Value = new System.DateTime(2023, 4, 6, 0, 0, 0, 0);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 0;
            this.bunifuPanel2.Controls.Add(this.label2);
            this.bunifuPanel2.Controls.Add(this.label1);
            this.bunifuPanel2.Controls.Add(this.bunifuLabel5);
            this.bunifuPanel2.Controls.Add(this.btncontact);
            this.bunifuPanel2.Controls.Add(this.btnbook);
            this.bunifuPanel2.Controls.Add(this.btnroom);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 65);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(209, 516);
            this.bunifuPanel2.TabIndex = 1;
            this.bunifuPanel2.Click += new System.EventHandler(this.bunifuPanel2_Click);
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
            // btncontact
            // 
            this.btncontact.BackColor = System.Drawing.Color.Transparent;
            this.btncontact.FlatAppearance.BorderSize = 0;
            this.btncontact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncontact.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontact.ForeColor = System.Drawing.Color.DimGray;
            this.btncontact.IconChar = FontAwesome.Sharp.IconChar.PhoneSquare;
            this.btncontact.IconColor = System.Drawing.Color.DimGray;
            this.btncontact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncontact.IconSize = 25;
            this.btncontact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncontact.Location = new System.Drawing.Point(0, 123);
            this.btncontact.Name = "btncontact";
            this.btncontact.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btncontact.Size = new System.Drawing.Size(200, 38);
            this.btncontact.TabIndex = 10;
            this.btncontact.Text = "   Contact Us";
            this.btncontact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncontact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncontact.UseVisualStyleBackColor = false;
            this.btncontact.Click += new System.EventHandler(this.btncontact_Click);
            this.btncontact.Leave += new System.EventHandler(this.btncontact_Leave);
            // 
            // btnbook
            // 
            this.btnbook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(156)))), ((int)(((byte)(49)))));
            this.btnbook.FlatAppearance.BorderSize = 0;
            this.btnbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbook.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbook.ForeColor = System.Drawing.Color.Transparent;
            this.btnbook.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.btnbook.IconColor = System.Drawing.Color.White;
            this.btnbook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbook.IconSize = 25;
            this.btnbook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbook.Location = new System.Drawing.Point(0, 35);
            this.btnbook.Name = "btnbook";
            this.btnbook.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnbook.Size = new System.Drawing.Size(200, 38);
            this.btnbook.TabIndex = 9;
            this.btnbook.Text = "   Book Now";
            this.btnbook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbook.UseVisualStyleBackColor = false;
            this.btnbook.Click += new System.EventHandler(this.btnbook_Click);
            this.btnbook.Leave += new System.EventHandler(this.btnbook_Leave);
            // 
            // btnroom
            // 
            this.btnroom.BackColor = System.Drawing.Color.Transparent;
            this.btnroom.FlatAppearance.BorderSize = 0;
            this.btnroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnroom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnroom.ForeColor = System.Drawing.Color.DimGray;
            this.btnroom.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnroom.IconColor = System.Drawing.Color.DimGray;
            this.btnroom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnroom.IconSize = 25;
            this.btnroom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnroom.Location = new System.Drawing.Point(0, 79);
            this.btnroom.Name = "btnroom";
            this.btnroom.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnroom.Size = new System.Drawing.Size(200, 38);
            this.btnroom.TabIndex = 8;
            this.btnroom.Text = "   Our Rooms";
            this.btnroom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnroom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnroom.UseVisualStyleBackColor = false;
            this.btnroom.Click += new System.EventHandler(this.btnroom_Click);
            this.btnroom.Leave += new System.EventHandler(this.btnroom_Leave);
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
            this.navbar.Controls.Add(this.iconButton1);
            this.navbar.Controls.Add(this.bunifuPictureBox1);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.ShowBorders = true;
            this.navbar.Size = new System.Drawing.Size(838, 65);
            this.navbar.TabIndex = 0;
            this.navbar.Click += new System.EventHandler(this.navbar_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.No;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(696, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(130, 38);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.Text = "   Customer";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuLabel6.Location = new System.Drawing.Point(11, 18);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(44, 15);
            this.bunifuLabel6.TabIndex = 0;
            this.bunifuLabel6.Text = "Booking";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AllowParentOverrides = false;
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.CursorType = null;
            this.bunifuLabel7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuLabel7.Location = new System.Drawing.Point(11, 33);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(198, 25);
            this.bunifuLabel7.TabIndex = 1;
            this.bunifuLabel7.Text = "Reserve Your Booking";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(235, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(838, 581);
            this.Controls.Add(this.childpanel);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.navbar);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.childpanel.ResumeLayout(false);
            this.childpanel.PerformLayout();
            this.namepanel.ResumeLayout(false);
            this.namepanel.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel navbar;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private FontAwesome.Sharp.IconButton btncontact;
        private FontAwesome.Sharp.IconButton btnbook;
        private FontAwesome.Sharp.IconButton btnroom;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Bunifu.UI.WinForms.BunifuPanel childpanel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuDatePicker Check_in;
        private Bunifu.UI.WinForms.BunifuDropdown adult;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuDatePicker Check_out;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuDropdown child;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Search;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private Bunifu.UI.WinForms.BunifuPanel namepanel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}