namespace Hotel_Management_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.childpanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.password = new Bunifu.UI.WinForms.BunifuTextBox();
            this.username = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.customer = new Bunifu.UI.WinForms.BunifuLabel();
            this.signup = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.signin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.childpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // childpanel
            // 
            this.childpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.childpanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.childpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("childpanel.BackgroundImage")));
            this.childpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.childpanel.BorderColor = System.Drawing.Color.Transparent;
            this.childpanel.BorderRadius = 3;
            this.childpanel.BorderThickness = 1;
            this.childpanel.Controls.Add(this.password);
            this.childpanel.Controls.Add(this.username);
            this.childpanel.Controls.Add(this.bunifuPictureBox1);
            this.childpanel.Controls.Add(this.bunifuLabel1);
            this.childpanel.Controls.Add(this.linkLabel1);
            this.childpanel.Controls.Add(this.bunifuPictureBox2);
            this.childpanel.Controls.Add(this.customer);
            this.childpanel.Controls.Add(this.signup);
            this.childpanel.Controls.Add(this.signin);
            this.childpanel.Controls.Add(this.pictureBox1);
            this.childpanel.Location = new System.Drawing.Point(0, 1);
            this.childpanel.Name = "childpanel";
            this.childpanel.ShowBorders = true;
            this.childpanel.Size = new System.Drawing.Size(807, 502);
            this.childpanel.TabIndex = 0;
            // 
            // password
            // 
            this.password.AcceptsReturn = false;
            this.password.AcceptsTab = false;
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password.AnimationSpeed = 200;
            this.password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.password.BackColor = System.Drawing.Color.White;
            this.password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("password.BackgroundImage")));
            this.password.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.password.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.password.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.password.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.password.BorderRadius = 30;
            this.password.BorderThickness = 1;
            this.password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.password.DefaultText = "";
            this.password.FillColor = System.Drawing.Color.WhiteSmoke;
            this.password.HideSelection = true;
            this.password.IconLeft = ((System.Drawing.Image)(resources.GetObject("password.IconLeft")));
            this.password.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.password.IconPadding = 10;
            this.password.IconRight = null;
            this.password.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Lines = new string[0];
            this.password.Location = new System.Drawing.Point(12, 256);
            this.password.MaxLength = 32767;
            this.password.MinimumSize = new System.Drawing.Size(1, 1);
            this.password.Modified = false;
            this.password.Multiline = false;
            this.password.Name = "password";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.password.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.password.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.password.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties4.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.password.OnIdleState = stateProperties4;
            this.password.Padding = new System.Windows.Forms.Padding(3);
            this.password.PasswordChar = '\0';
            this.password.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.password.PlaceholderText = "Enter Password";
            this.password.ReadOnly = false;
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.ShortcutsEnabled = true;
            this.password.Size = new System.Drawing.Size(284, 38);
            this.password.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.password.TabIndex = 2;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.TextMarginBottom = 0;
            this.password.TextMarginLeft = 5;
            this.password.TextMarginTop = 0;
            this.password.TextPlaceholder = "Enter Password";
            this.password.UseSystemPasswordChar = false;
            this.password.WordWrap = true;
            this.password.Click += new System.EventHandler(this.password_Click);
            this.password.Enter += new System.EventHandler(this.password_Enter);
            // 
            // username
            // 
            this.username.AcceptsReturn = false;
            this.username.AcceptsTab = false;
            this.username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.username.AnimationSpeed = 200;
            this.username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.username.BackColor = System.Drawing.Color.White;
            this.username.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("username.BackgroundImage")));
            this.username.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.username.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.username.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.username.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.username.BorderRadius = 30;
            this.username.BorderThickness = 1;
            this.username.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.username.DefaultText = "";
            this.username.FillColor = System.Drawing.Color.WhiteSmoke;
            this.username.HideSelection = true;
            this.username.IconLeft = ((System.Drawing.Image)(resources.GetObject("username.IconLeft")));
            this.username.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.username.IconPadding = 10;
            this.username.IconRight = null;
            this.username.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.username.Lines = new string[0];
            this.username.Location = new System.Drawing.Point(12, 208);
            this.username.MaxLength = 32767;
            this.username.MinimumSize = new System.Drawing.Size(1, 1);
            this.username.Modified = false;
            this.username.Multiline = false;
            this.username.Name = "username";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.username.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.username.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.username.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties8.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.username.OnIdleState = stateProperties8;
            this.username.Padding = new System.Windows.Forms.Padding(3);
            this.username.PasswordChar = '\0';
            this.username.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.username.PlaceholderText = "Enter username";
            this.username.ReadOnly = false;
            this.username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.username.SelectedText = "";
            this.username.SelectionLength = 0;
            this.username.SelectionStart = 0;
            this.username.ShortcutsEnabled = true;
            this.username.Size = new System.Drawing.Size(284, 38);
            this.username.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.username.TabIndex = 1;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.username.TextMarginBottom = 0;
            this.username.TextMarginLeft = 5;
            this.username.TextMarginTop = 0;
            this.username.TextPlaceholder = "Enter username";
            this.username.UseSystemPasswordChar = false;
            this.username.WordWrap = true;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BackColor = System.Drawing.Color.White;
            this.bunifuPictureBox1.BorderRadius = 124;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(24, -19);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(248, 248);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 17;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.BackColor = System.Drawing.Color.White;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel1.Location = new System.Drawing.Point(78, 431);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(90, 15);
            this.bunifuLabel1.TabIndex = 16;
            this.bunifuLabel1.Text = "Visit Our Website";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(74, 443);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(152, 21);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.hotelion.me";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.AutoSizeHeight = true;
            this.bunifuPictureBox2.BackColor = System.Drawing.Color.White;
            this.bunifuPictureBox2.BorderRadius = 51;
            this.bunifuPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox2.Image")));
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(0, 400);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(102, 102);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 14;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // customer
            // 
            this.customer.AllowParentOverrides = false;
            this.customer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customer.AutoEllipsis = false;
            this.customer.BackColor = System.Drawing.Color.White;
            this.customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customer.CursorType = System.Windows.Forms.Cursors.Hand;
            this.customer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.ForeColor = System.Drawing.Color.Red;
            this.customer.Location = new System.Drawing.Point(156, 300);
            this.customer.Name = "customer";
            this.customer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customer.Size = new System.Drawing.Size(116, 17);
            this.customer.TabIndex = 9;
            this.customer.Text = "Are You customer?";
            this.customer.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.customer.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // signup
            // 
            this.signup.AllowAnimations = true;
            this.signup.AllowMouseEffects = true;
            this.signup.AllowToggling = false;
            this.signup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signup.AnimationSpeed = 200;
            this.signup.AutoGenerateColors = false;
            this.signup.AutoRoundBorders = false;
            this.signup.AutoSizeLeftIcon = true;
            this.signup.AutoSizeRightIcon = true;
            this.signup.BackColor = System.Drawing.Color.Transparent;
            this.signup.BackColor1 = System.Drawing.Color.Transparent;
            this.signup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signup.BackgroundImage")));
            this.signup.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.signup.ButtonText = "Sign Up";
            this.signup.ButtonTextMarginLeft = 0;
            this.signup.ColorContrastOnClick = 45;
            this.signup.ColorContrastOnHover = 45;
            this.signup.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.signup.CustomizableEdges = borderEdges1;
            this.signup.DialogResult = System.Windows.Forms.DialogResult.None;
            this.signup.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.signup.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.signup.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.signup.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.signup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(44)))));
            this.signup.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signup.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.signup.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.signup.IconMarginLeft = 11;
            this.signup.IconPadding = 10;
            this.signup.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.signup.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.signup.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.signup.IconSize = 25;
            this.signup.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(44)))));
            this.signup.IdleBorderRadius = 30;
            this.signup.IdleBorderThickness = 2;
            this.signup.IdleFillColor = System.Drawing.Color.Transparent;
            this.signup.IdleIconLeftImage = null;
            this.signup.IdleIconRightImage = null;
            this.signup.IndicateFocus = false;
            this.signup.Location = new System.Drawing.Point(157, 328);
            this.signup.Name = "signup";
            this.signup.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.signup.OnDisabledState.BorderRadius = 30;
            this.signup.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.signup.OnDisabledState.BorderThickness = 2;
            this.signup.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.signup.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.signup.OnDisabledState.IconLeftImage = null;
            this.signup.OnDisabledState.IconRightImage = null;
            this.signup.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.signup.onHoverState.BorderRadius = 30;
            this.signup.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.signup.onHoverState.BorderThickness = 2;
            this.signup.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.signup.onHoverState.ForeColor = System.Drawing.Color.White;
            this.signup.onHoverState.IconLeftImage = null;
            this.signup.onHoverState.IconRightImage = null;
            this.signup.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(44)))));
            this.signup.OnIdleState.BorderRadius = 30;
            this.signup.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.signup.OnIdleState.BorderThickness = 2;
            this.signup.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.signup.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(44)))));
            this.signup.OnIdleState.IconLeftImage = null;
            this.signup.OnIdleState.IconRightImage = null;
            this.signup.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.signup.OnPressedState.BorderRadius = 30;
            this.signup.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.signup.OnPressedState.BorderThickness = 2;
            this.signup.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.signup.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.signup.OnPressedState.IconLeftImage = null;
            this.signup.OnPressedState.IconRightImage = null;
            this.signup.Size = new System.Drawing.Size(119, 37);
            this.signup.TabIndex = 4;
            this.signup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signup.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.signup.TextMarginLeft = 0;
            this.signup.TextPadding = new System.Windows.Forms.Padding(0);
            this.signup.UseDefaultRadiusAndThickness = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // signin
            // 
            this.signin.AllowAnimations = true;
            this.signin.AllowMouseEffects = true;
            this.signin.AllowToggling = false;
            this.signin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signin.AnimationSpeed = 200;
            this.signin.AutoGenerateColors = false;
            this.signin.AutoRoundBorders = false;
            this.signin.AutoSizeLeftIcon = true;
            this.signin.AutoSizeRightIcon = true;
            this.signin.BackColor = System.Drawing.Color.Transparent;
            this.signin.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(44)))));
            this.signin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signin.BackgroundImage")));
            this.signin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.signin.ButtonText = "Sign in\r\n";
            this.signin.ButtonTextMarginLeft = 0;
            this.signin.ColorContrastOnClick = 45;
            this.signin.ColorContrastOnHover = 45;
            this.signin.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.signin.CustomizableEdges = borderEdges2;
            this.signin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.signin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.signin.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.signin.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.signin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.signin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.ForeColor = System.Drawing.Color.White;
            this.signin.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signin.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.signin.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.signin.IconMarginLeft = 11;
            this.signin.IconPadding = 10;
            this.signin.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.signin.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.signin.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.signin.IconSize = 25;
            this.signin.IdleBorderColor = System.Drawing.Color.Transparent;
            this.signin.IdleBorderRadius = 30;
            this.signin.IdleBorderThickness = 1;
            this.signin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(44)))));
            this.signin.IdleIconLeftImage = null;
            this.signin.IdleIconRightImage = null;
            this.signin.IndicateFocus = false;
            this.signin.Location = new System.Drawing.Point(26, 328);
            this.signin.Name = "signin";
            this.signin.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.signin.OnDisabledState.BorderRadius = 30;
            this.signin.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.signin.OnDisabledState.BorderThickness = 1;
            this.signin.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.signin.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.signin.OnDisabledState.IconLeftImage = null;
            this.signin.OnDisabledState.IconRightImage = null;
            this.signin.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.signin.onHoverState.BorderRadius = 30;
            this.signin.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.signin.onHoverState.BorderThickness = 1;
            this.signin.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.signin.onHoverState.ForeColor = System.Drawing.Color.White;
            this.signin.onHoverState.IconLeftImage = null;
            this.signin.onHoverState.IconRightImage = null;
            this.signin.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.signin.OnIdleState.BorderRadius = 30;
            this.signin.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.signin.OnIdleState.BorderThickness = 1;
            this.signin.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(44)))));
            this.signin.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.signin.OnIdleState.IconLeftImage = null;
            this.signin.OnIdleState.IconRightImage = null;
            this.signin.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.signin.OnPressedState.BorderRadius = 30;
            this.signin.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.signin.OnPressedState.BorderThickness = 1;
            this.signin.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.signin.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.signin.OnPressedState.IconLeftImage = null;
            this.signin.OnPressedState.IconRightImage = null;
            this.signin.Size = new System.Drawing.Size(115, 37);
            this.signin.TabIndex = 3;
            this.signin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.signin.TextMarginLeft = 0;
            this.signin.TextPadding = new System.Windows.Forms.Padding(0);
            this.signin.UseDefaultRadiusAndThickness = true;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-64, -196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(935, 912);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 504);
            this.Controls.Add(this.childpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hotel Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.childpanel.ResumeLayout(false);
            this.childpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel childpanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton signin;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton signup;
        private Bunifu.UI.WinForms.BunifuLabel customer;
        private Bunifu.UI.WinForms.BunifuTextBox username;
        private Bunifu.UI.WinForms.BunifuTextBox password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}

