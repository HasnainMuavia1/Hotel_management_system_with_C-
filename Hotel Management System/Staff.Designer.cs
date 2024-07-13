namespace Hotel_Management_System
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.childpanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.grid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.namepanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.Delete = new FontAwesome.Sharp.IconButton();
            this.AddBooking = new FontAwesome.Sharp.IconButton();
            this.btnback = new FontAwesome.Sharp.IconButton();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.childpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.namepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // childpanel
            // 
            this.childpanel.BackgroundColor = System.Drawing.Color.White;
            this.childpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("childpanel.BackgroundImage")));
            this.childpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.childpanel.BorderColor = System.Drawing.Color.Transparent;
            this.childpanel.BorderRadius = 3;
            this.childpanel.BorderThickness = 1;
            this.childpanel.Controls.Add(this.grid);
            this.childpanel.Controls.Add(this.namepanel);
            this.childpanel.Location = new System.Drawing.Point(0, 0);
            this.childpanel.Name = "childpanel";
            this.childpanel.ShowBorders = true;
            this.childpanel.Size = new System.Drawing.Size(586, 444);
            this.childpanel.TabIndex = 3;
            this.childpanel.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // grid
            // 
            this.grid.AllowCustomTheming = false;
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(226)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(111)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.grid.HeaderBackColor = System.Drawing.Color.ForestGreen;
            this.grid.HeaderBgColor = System.Drawing.Color.Empty;
            this.grid.HeaderForeColor = System.Drawing.Color.White;
            this.grid.Location = new System.Drawing.Point(3, 75);
            this.grid.Name = "grid";
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid.RowTemplate.Height = 40;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(571, 367);
            this.grid.TabIndex = 14;
            this.grid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.ForestGreen;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // namepanel
            // 
            this.namepanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.namepanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("namepanel.BackgroundImage")));
            this.namepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.namepanel.BorderColor = System.Drawing.Color.Transparent;
            this.namepanel.BorderRadius = 3;
            this.namepanel.BorderThickness = 1;
            this.namepanel.Controls.Add(this.Delete);
            this.namepanel.Controls.Add(this.AddBooking);
            this.namepanel.Controls.Add(this.btnback);
            this.namepanel.Controls.Add(this.bunifuLabel6);
            this.namepanel.Location = new System.Drawing.Point(0, 0);
            this.namepanel.Name = "namepanel";
            this.namepanel.ShowBorders = true;
            this.namepanel.Size = new System.Drawing.Size(586, 73);
            this.namepanel.TabIndex = 2;
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(156)))), ((int)(((byte)(49)))));
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.Transparent;
            this.Delete.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.Delete.IconColor = System.Drawing.Color.White;
            this.Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Delete.IconSize = 15;
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.Location = new System.Drawing.Point(471, 34);
            this.Delete.Name = "Delete";
            this.Delete.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Delete.Size = new System.Drawing.Size(105, 35);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "   Delete User";
            this.Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // AddBooking
            // 
            this.AddBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(156)))), ((int)(((byte)(49)))));
            this.AddBooking.FlatAppearance.BorderSize = 0;
            this.AddBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBooking.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBooking.ForeColor = System.Drawing.Color.Transparent;
            this.AddBooking.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.AddBooking.IconColor = System.Drawing.Color.White;
            this.AddBooking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddBooking.IconSize = 15;
            this.AddBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBooking.Location = new System.Drawing.Point(360, 34);
            this.AddBooking.Name = "AddBooking";
            this.AddBooking.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AddBooking.Size = new System.Drawing.Size(105, 35);
            this.AddBooking.TabIndex = 11;
            this.AddBooking.Text = "   Add User";
            this.AddBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBooking.UseVisualStyleBackColor = false;
            this.AddBooking.Click += new System.EventHandler(this.AddBooking_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.DimGray;
            this.btnback.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnback.IconColor = System.Drawing.Color.DimGray;
            this.btnback.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnback.IconSize = 20;
            this.btnback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnback.Location = new System.Drawing.Point(2, 35);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(142, 38);
            this.btnback.TabIndex = 9;
            this.btnback.Text = "Staff Details";
            this.btnback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuLabel6.Location = new System.Drawing.Point(36, 21);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(36, 15);
            this.bunifuLabel6.TabIndex = 0;
            this.bunifuLabel6.Text = "Details";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 444);
            this.Controls.Add(this.childpanel);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.childpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.namepanel.ResumeLayout(false);
            this.namepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel childpanel;
        private Bunifu.UI.WinForms.BunifuPanel namepanel;
        private FontAwesome.Sharp.IconButton btnback;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuDataGridView grid;
        private FontAwesome.Sharp.IconButton Delete;
        private FontAwesome.Sharp.IconButton AddBooking;
    }
}