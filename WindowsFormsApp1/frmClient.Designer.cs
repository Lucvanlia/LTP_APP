namespace WindowsFormsApp1
{
    partial class frmClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnYoutube = new Guna.UI2.WinForms.Guna2Button();
            this.btnWin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.picIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.timerCheckInternet = new System.Windows.Forms.Timer(this.components);
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.btnYoutube);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnWin);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Enabled = true;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(100, 477);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // btnYoutube
            // 
            this.btnYoutube.Animated = true;
            this.btnYoutube.BackColor = System.Drawing.Color.Transparent;
            this.btnYoutube.BorderColor = System.Drawing.Color.Transparent;
            this.btnYoutube.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnYoutube.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnYoutube.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnYoutube.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnYoutube.CustomImages.CheckedImage = global::WindowsFormsApp1.Properties.Resources.icons8_youtube_48;
            this.btnYoutube.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnYoutube.CustomImages.ImageSize = new System.Drawing.Size(48, 48);
            this.btnYoutube.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYoutube.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYoutube.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYoutube.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYoutube.FillColor = System.Drawing.Color.Transparent;
            this.btnYoutube.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYoutube.ForeColor = System.Drawing.Color.Transparent;
            this.btnYoutube.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnYoutube.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnYoutube.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnYoutube.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btnYoutube.Location = new System.Drawing.Point(12, 0);
            this.btnYoutube.Name = "btnYoutube";
            this.btnYoutube.Size = new System.Drawing.Size(69, 61);
            this.btnYoutube.TabIndex = 7;
            this.btnYoutube.UseTransparentBackground = true;
            this.btnYoutube.Click += new System.EventHandler(this.btnYoutube_Click);
            // 
            // btnWin
            // 
            this.btnWin.Animated = true;
            this.btnWin.BackColor = System.Drawing.Color.Transparent;
            this.btnWin.BorderColor = System.Drawing.Color.Transparent;
            this.btnWin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnWin.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnWin.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnWin.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnWin.CustomImages.CheckedImage = global::WindowsFormsApp1.Properties.Resources.icons8_windows_os_48;
            this.btnWin.CustomImages.HoveredImage = global::WindowsFormsApp1.Properties.Resources.icons8_windows_os_48;
            this.btnWin.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnWin.CustomImages.ImageSize = new System.Drawing.Size(48, 48);
            this.btnWin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWin.FillColor = System.Drawing.Color.Transparent;
            this.btnWin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWin.ForeColor = System.Drawing.Color.Transparent;
            this.btnWin.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnWin.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnWin.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnWin.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btnWin.Location = new System.Drawing.Point(12, 67);
            this.btnWin.Name = "btnWin";
            this.btnWin.Size = new System.Drawing.Size(69, 61);
            this.btnWin.TabIndex = 8;
            this.btnWin.UseTransparentBackground = true;
            this.btnWin.Click += new System.EventHandler(this.btnWin_Click);
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this.picIcon);
            this.guna2CustomGradientPanel2.Controls.Add(this.lblTrangThai);
            this.guna2CustomGradientPanel2.Controls.Add(this.label1);
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(100, 0);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.BorderRadius = 1;
            this.guna2CustomGradientPanel2.ShadowDecoration.Depth = 55;
            this.guna2CustomGradientPanel2.ShadowDecoration.Enabled = true;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(720, 55);
            this.guna2CustomGradientPanel2.TabIndex = 2;
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.FillColor = System.Drawing.Color.Transparent;
            this.picIcon.ImageRotate = 0F;
            this.picIcon.InitialImage = global::WindowsFormsApp1.Properties.Resources.icon_success;
            this.picIcon.Location = new System.Drawing.Point(620, 9);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(68, 43);
            this.picIcon.TabIndex = 3;
            this.picIcon.TabStop = false;
            this.picIcon.UseTransparentBackground = true;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.ForeColor = System.Drawing.Color.White;
            this.lblTrangThai.Location = new System.Drawing.Point(347, 18);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(158, 25);
            this.lblTrangThai.TabIndex = 2;
            this.lblTrangThai.Text = "Trạng thái mạng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "LTP - APP ";
            // 
            // pnMain
            // 
            this.pnMain.Location = new System.Drawing.Point(107, 67);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(713, 410);
            this.pnMain.TabIndex = 3;
            // 
            // timerCheckInternet
            // 
            this.timerCheckInternet.Interval = 10000;
            this.timerCheckInternet.Tick += new System.EventHandler(this.timerCheckInternet_Tick_1);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 477);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "frmClient";
            this.Text = "frmClient";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2Button btnYoutube;
        private Guna.UI2.WinForms.Guna2Button btnWin;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private System.Windows.Forms.Label lblTrangThai;
        private Guna.UI2.WinForms.Guna2PictureBox picIcon;
        private System.Windows.Forms.Timer timerCheckInternet;
    }
}