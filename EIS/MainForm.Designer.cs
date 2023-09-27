namespace EIS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SpinningLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.ToogleDarkModeButton = new FontAwesome.Sharp.IconButton();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.HomeButton = new FontAwesome.Sharp.IconButton();
            this.ManageButton = new FontAwesome.Sharp.IconButton();
            this.ReportsButton = new FontAwesome.Sharp.IconButton();
            this.LibraryButton = new FontAwesome.Sharp.IconButton();
            this.LogoutButton = new FontAwesome.Sharp.IconButton();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MainGroupBox = new System.Windows.Forms.GroupBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.DateTimeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DateTimeStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.DeveloperStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeTimer = new System.Windows.Forms.Timer(this.components);
            this.TitleIconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.kryptonPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SpinningLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            this.MainGroupBox.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SpinningLogoPictureBox
            // 
            this.SpinningLogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SpinningLogoPictureBox.ErrorImage = global::EIS.Properties.Resources.err;
            this.SpinningLogoPictureBox.Image = global::EIS.Properties.Resources.csu_small;
            this.SpinningLogoPictureBox.Location = new System.Drawing.Point(1, 0);
            this.SpinningLogoPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.SpinningLogoPictureBox.Name = "SpinningLogoPictureBox";
            this.SpinningLogoPictureBox.Size = new System.Drawing.Size(40, 52);
            this.SpinningLogoPictureBox.TabIndex = 3;
            this.SpinningLogoPictureBox.TabStop = false;
            this.SpinningLogoPictureBox.WaitOnLoad = true;
            // 
            // ToogleDarkModeButton
            // 
            this.ToogleDarkModeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToogleDarkModeButton.BackColor = System.Drawing.Color.Transparent;
            this.ToogleDarkModeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ToogleDarkModeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ToogleDarkModeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ToogleDarkModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToogleDarkModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.ToogleDarkModeButton.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            this.ToogleDarkModeButton.IconColor = System.Drawing.Color.Black;
            this.ToogleDarkModeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ToogleDarkModeButton.IconSize = 20;
            this.ToogleDarkModeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToogleDarkModeButton.Location = new System.Drawing.Point(1269, 1);
            this.ToogleDarkModeButton.Margin = new System.Windows.Forms.Padding(4);
            this.ToogleDarkModeButton.Name = "ToogleDarkModeButton";
            this.ToogleDarkModeButton.Size = new System.Drawing.Size(109, 27);
            this.ToogleDarkModeButton.TabIndex = 0;
            this.ToogleDarkModeButton.Text = "DARK MODE";
            this.ToogleDarkModeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ToogleDarkModeButton.UseVisualStyleBackColor = false;
            this.ToogleDarkModeButton.Click += new System.EventHandler(this.ToogleDarkModeButton_Click);
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.BackColor = System.Drawing.Color.Transparent;
            this.ProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfilePicture.Image = global::EIS.Properties.Resources.profile;
            this.ProfilePicture.InitialImage = null;
            this.ProfilePicture.Location = new System.Drawing.Point(39, 37);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(75, 76);
            this.ProfilePicture.TabIndex = 101;
            this.ProfilePicture.TabStop = false;
            this.ProfilePicture.Click += new System.EventHandler(this.ProfilePicture_Click);
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.Image = global::EIS.Properties.Resources.profile_border;
            this.ProfilePictureBox.Location = new System.Drawing.Point(2, 0);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(151, 155);
            this.ProfilePictureBox.TabIndex = 100;
            this.ProfilePictureBox.TabStop = false;
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.HomeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.HomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.HomeButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(216)))), ((int)(((byte)(59)))));
            this.HomeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HomeButton.IconSize = 30;
            this.HomeButton.Location = new System.Drawing.Point(2, 161);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(151, 44);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "HOME";
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // ManageButton
            // 
            this.ManageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ManageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ManageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ManageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageButton.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.ManageButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.ManageButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ManageButton.IconSize = 30;
            this.ManageButton.Location = new System.Drawing.Point(2, 211);
            this.ManageButton.Name = "ManageButton";
            this.ManageButton.Size = new System.Drawing.Size(151, 44);
            this.ManageButton.TabIndex = 102;
            this.ManageButton.Text = "MANAGE";
            this.ManageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManageButton.UseVisualStyleBackColor = true;
            this.ManageButton.Click += new System.EventHandler(this.ManageButton_Click);
            // 
            // ReportsButton
            // 
            this.ReportsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ReportsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ReportsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ReportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportsButton.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.ReportsButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ReportsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReportsButton.IconSize = 30;
            this.ReportsButton.Location = new System.Drawing.Point(1, 261);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(151, 44);
            this.ReportsButton.TabIndex = 103;
            this.ReportsButton.Text = "REPORTS";
            this.ReportsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReportsButton.UseVisualStyleBackColor = true;
            this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // LibraryButton
            // 
            this.LibraryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LibraryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LibraryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.LibraryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LibraryButton.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            this.LibraryButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.LibraryButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LibraryButton.IconSize = 30;
            this.LibraryButton.Location = new System.Drawing.Point(1, 311);
            this.LibraryButton.Name = "LibraryButton";
            this.LibraryButton.Size = new System.Drawing.Size(151, 44);
            this.LibraryButton.TabIndex = 104;
            this.LibraryButton.Text = "LIBRARY";
            this.LibraryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LibraryButton.UseVisualStyleBackColor = true;
            this.LibraryButton.Click += new System.EventHandler(this.LibraryButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LogoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LogoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.ForeColor = System.Drawing.Color.Black;
            this.LogoutButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.LogoutButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LogoutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogoutButton.IconSize = 30;
            this.LogoutButton.Location = new System.Drawing.Point(2, 361);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(151, 44);
            this.LogoutButton.TabIndex = 105;
            this.LogoutButton.Text = "LOG-OUT";
            this.LogoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(193, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(41, 15);
            this.TitleLabel.TabIndex = 106;
            this.TitleLabel.Text = "Home";
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainGroupBox.Controls.Add(this.MainPanel);
            this.MainGroupBox.Location = new System.Drawing.Point(159, 30);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Size = new System.Drawing.Size(1208, 612);
            this.MainGroupBox.TabIndex = 107;
            this.MainGroupBox.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(3, 17);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1202, 592);
            this.MainPanel.TabIndex = 0;
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.BackColor = System.Drawing.Color.Transparent;
            this.MainStatusStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DateTimeStatusLabel,
            this.DateTimeStatus,
            this.DeveloperStatus});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 645);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(1379, 22);
            this.MainStatusStrip.TabIndex = 108;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // DateTimeStatusLabel
            // 
            this.DateTimeStatusLabel.Name = "DateTimeStatusLabel";
            this.DateTimeStatusLabel.Size = new System.Drawing.Size(36, 17);
            this.DateTimeStatusLabel.Text = "Date:";
            // 
            // DateTimeStatus
            // 
            this.DateTimeStatus.Name = "DateTimeStatus";
            this.DateTimeStatus.Size = new System.Drawing.Size(69, 17);
            this.DateTimeStatus.Text = "HH:MM:SS";
            // 
            // DeveloperStatus
            // 
            this.DeveloperStatus.Name = "DeveloperStatus";
            this.DeveloperStatus.Size = new System.Drawing.Size(222, 17);
            this.DeveloperStatus.Text = "Made with love by Kalvin Karl C. Nonato";
            // 
            // TimeTimer
            // 
            this.TimeTimer.Enabled = true;
            this.TimeTimer.Tick += new System.EventHandler(this.TimeTimer_Tick);
            // 
            // TitleIconPictureBox
            // 
            this.TitleIconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.TitleIconPictureBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(216)))), ((int)(((byte)(59)))));
            this.TitleIconPictureBox.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.TitleIconPictureBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(216)))), ((int)(((byte)(59)))));
            this.TitleIconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TitleIconPictureBox.IconSize = 28;
            this.TitleIconPictureBox.Location = new System.Drawing.Point(159, 5);
            this.TitleIconPictureBox.Name = "TitleIconPictureBox";
            this.TitleIconPictureBox.Size = new System.Drawing.Size(28, 28);
            this.TitleIconPictureBox.TabIndex = 109;
            this.TitleIconPictureBox.TabStop = false;
            // 
            // kryptonPalette
            // 
            this.kryptonPalette.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.kryptonPalette.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette.ButtonSpecs.FormClose.Image")));
            this.kryptonPalette.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette.ButtonSpecs.FormMax.Image")));
            this.kryptonPalette.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette.ButtonSpecs.FormMin.Image")));
            this.kryptonPalette.ButtonSpecs.FormRestore.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette.ButtonSpecs.FormRestore.Image")));
            this.kryptonPalette.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 0;
            this.kryptonPalette.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.kryptonPalette.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(8, -1, -1, -1);
            this.kryptonPalette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.kryptonPalette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nunito", 12F);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1379, 667);
            this.Controls.Add(this.TitleIconPictureBox);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.LibraryButton);
            this.Controls.Add(this.ReportsButton);
            this.Controls.Add(this.ManageButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.SpinningLogoPictureBox);
            this.Controls.Add(this.ToogleDarkModeButton);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.ProfilePictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "MainForm";
            this.Palette = this.kryptonPalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.Text = "Employee Information Management System v1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpinningLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            this.MainGroupBox.ResumeLayout(false);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleIconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton ToogleDarkModeButton;
        private System.Windows.Forms.PictureBox SpinningLogoPictureBox;
        private System.Windows.Forms.PictureBox ProfilePictureBox;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private FontAwesome.Sharp.IconButton HomeButton;
        private FontAwesome.Sharp.IconButton ManageButton;
        private FontAwesome.Sharp.IconButton ReportsButton;
        private FontAwesome.Sharp.IconButton LibraryButton;
        private FontAwesome.Sharp.IconButton LogoutButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.GroupBox MainGroupBox;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel DateTimeStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel DateTimeStatus;
        private System.Windows.Forms.Timer TimeTimer;
        private FontAwesome.Sharp.IconPictureBox TitleIconPictureBox;
        private System.Windows.Forms.Panel MainPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette;
        private System.Windows.Forms.ToolStripStatusLabel DeveloperStatus;
    }
}

