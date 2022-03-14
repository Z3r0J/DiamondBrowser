
namespace WebBrowser
{
    partial class frmMain
    {
        AppContainer Container = new AppContainer();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtUrl = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnForward = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnRefresh = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loader = new System.Windows.Forms.PictureBox();
            this.SecurityIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecurityIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.BtnForward);
            this.panel1.Controls.Add(this.BtnBack);
            this.panel1.Controls.Add(this.BtnRefresh);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 65);
            this.panel1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 19;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.pictureBox2);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.loader);
            this.guna2Panel1.Controls.Add(this.txtUrl);
            this.guna2Panel1.Controls.Add(this.SecurityIcon);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel1.Location = new System.Drawing.Point(124, 10);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(928, 37);
            this.guna2Panel1.TabIndex = 0;
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUrl.BorderThickness = 0;
            this.txtUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrl.DefaultText = "";
            this.txtUrl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUrl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUrl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrl.DisabledState.Parent = this.txtUrl;
            this.txtUrl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUrl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrl.FocusedState.Parent = this.txtUrl;
            this.txtUrl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrl.HoverState.Parent = this.txtUrl;
            this.txtUrl.Location = new System.Drawing.Point(44, 8);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.PasswordChar = '\0';
            this.txtUrl.PlaceholderText = "";
            this.txtUrl.SelectedText = "";
            this.txtUrl.ShadowDecoration.Parent = this.txtUrl;
            this.txtUrl.Size = new System.Drawing.Size(880, 22);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyUp);
            // 
            // pnlBody
            // 
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 65);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1109, 668);
            this.pnlBody.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "shield.png");
            this.imageList1.Images.SetKeyName(1, "unsecure.png");
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::WebBrowser.Properties.Resources.settings;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1072, 16);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // BtnForward
            // 
            this.BtnForward.BackColor = System.Drawing.Color.Transparent;
            this.BtnForward.Image = global::WebBrowser.Properties.Resources.next;
            this.BtnForward.ImageActive = null;
            this.BtnForward.Location = new System.Drawing.Point(45, 16);
            this.BtnForward.Name = "BtnForward";
            this.BtnForward.Size = new System.Drawing.Size(25, 25);
            this.BtnForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnForward.TabIndex = 2;
            this.BtnForward.TabStop = false;
            this.BtnForward.Zoom = 10;
            this.BtnForward.Click += new System.EventHandler(this.BtnForward_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack.Image = global::WebBrowser.Properties.Resources.back;
            this.BtnBack.ImageActive = null;
            this.BtnBack.Location = new System.Drawing.Point(13, 16);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(25, 25);
            this.BtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnBack.TabIndex = 1;
            this.BtnBack.TabStop = false;
            this.BtnBack.Zoom = 10;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefresh.Image = global::WebBrowser.Properties.Resources.refresh1;
            this.BtnRefresh.ImageActive = null;
            this.BtnRefresh.Location = new System.Drawing.Point(83, 16);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(25, 25);
            this.BtnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRefresh.TabIndex = 0;
            this.BtnRefresh.TabStop = false;
            this.BtnRefresh.Zoom = 10;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::WebBrowser.Properties.Resources.no_favorite;
            this.pictureBox1.Location = new System.Drawing.Point(892, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // loader
            // 
            this.loader.Image = global::WebBrowser.Properties.Resources.loading;
            this.loader.Location = new System.Drawing.Point(7, 3);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(30, 29);
            this.loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loader.TabIndex = 2;
            this.loader.TabStop = false;
            this.loader.Visible = false;
            // 
            // SecurityIcon
            // 
            this.SecurityIcon.Image = global::WebBrowser.Properties.Resources._lock;
            this.SecurityIcon.Location = new System.Drawing.Point(10, 7);
            this.SecurityIcon.Name = "SecurityIcon";
            this.SecurityIcon.Size = new System.Drawing.Size(20, 20);
            this.SecurityIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SecurityIcon.TabIndex = 0;
            this.SecurityIcon.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::WebBrowser.Properties.Resources.favorite;
            this.pictureBox2.Location = new System.Drawing.Point(892, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 733);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecurityIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox SecurityIcon;
        private Guna.UI2.WinForms.Guna2TextBox txtUrl;
        private System.Windows.Forms.Panel pnlBody;
        private Bunifu.Framework.UI.BunifuImageButton BtnRefresh;
        private Bunifu.Framework.UI.BunifuImageButton BtnForward;
        private Bunifu.Framework.UI.BunifuImageButton BtnBack;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox loader;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

