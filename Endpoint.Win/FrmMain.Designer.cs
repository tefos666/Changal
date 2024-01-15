namespace Endpoint.Win
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            RibbonBar = new Panel();
            lblBasicInfoHeader = new Label();
            label1 = new Label();
            SectionPayment = new Panel();
            lblPayment = new LinkLabel();
            PbPayment = new PictureBox();
            pictureBox1 = new PictureBox();
            SectionBasicInfo = new Panel();
            lblFoodMenu = new LinkLabel();
            PbFoodMenu = new PictureBox();
            PbSelected = new PictureBox();
            SectionHeaderBasicInfo = new PictureBox();
            SectionSignOut = new Panel();
            lblSignOut = new LinkLabel();
            PbSignOut = new PictureBox();
            Logo = new PictureBox();
            Content = new Panel();
            RibbonBar.SuspendLayout();
            SectionPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbPayment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SectionBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbFoodMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbSelected).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SectionHeaderBasicInfo).BeginInit();
            SectionSignOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbSignOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // RibbonBar
            // 
            RibbonBar.BackColor = Color.LightSkyBlue;
            RibbonBar.BackgroundImageLayout = ImageLayout.Stretch;
            RibbonBar.Controls.Add(lblBasicInfoHeader);
            RibbonBar.Controls.Add(label1);
            RibbonBar.Controls.Add(SectionPayment);
            RibbonBar.Controls.Add(pictureBox1);
            RibbonBar.Controls.Add(SectionBasicInfo);
            RibbonBar.Controls.Add(SectionHeaderBasicInfo);
            RibbonBar.Controls.Add(SectionSignOut);
            RibbonBar.Controls.Add(Logo);
            RibbonBar.Dock = DockStyle.Left;
            RibbonBar.Location = new Point(0, 43);
            RibbonBar.Name = "RibbonBar";
            RibbonBar.Size = new Size(210, 709);
            RibbonBar.TabIndex = 1;
            // 
            // lblBasicInfoHeader
            // 
            lblBasicInfoHeader.AutoSize = true;
            lblBasicInfoHeader.BackColor = Color.FromArgb(255, 128, 128);
            lblBasicInfoHeader.Font = new Font("IRANSans(FaNum)", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBasicInfoHeader.ForeColor = Color.White;
            lblBasicInfoHeader.Location = new Point(69, 99);
            lblBasicInfoHeader.Name = "lblBasicInfoHeader";
            lblBasicInfoHeader.Size = new Size(85, 25);
            lblBasicInfoHeader.TabIndex = 18;
            lblBasicInfoHeader.Text = "اطلاعات پایه";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 128);
            label1.Font = new Font("IRANSans(FaNum)", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(85, 186);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 17;
            label1.Text = "صندوق";
            // 
            // SectionPayment
            // 
            SectionPayment.Controls.Add(lblPayment);
            SectionPayment.Controls.Add(PbPayment);
            SectionPayment.Dock = DockStyle.Top;
            SectionPayment.Location = new Point(0, 213);
            SectionPayment.Name = "SectionPayment";
            SectionPayment.Size = new Size(210, 49);
            SectionPayment.TabIndex = 16;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Location = new Point(35, 17);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(105, 25);
            lblPayment.TabIndex = 11;
            lblPayment.TabStop = true;
            lblPayment.Text = "دریافت پرداخت";
            // 
            // PbPayment
            // 
            PbPayment.BackgroundImageLayout = ImageLayout.Stretch;
            PbPayment.Image = (Image)resources.GetObject("PbPayment.Image");
            PbPayment.Location = new Point(147, 3);
            PbPayment.Name = "PbPayment";
            PbPayment.Size = new Size(39, 41);
            PbPayment.SizeMode = PictureBoxSizeMode.StretchImage;
            PbPayment.TabIndex = 10;
            PbPayment.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 128, 128);
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 183);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 30);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // SectionBasicInfo
            // 
            SectionBasicInfo.Controls.Add(lblFoodMenu);
            SectionBasicInfo.Controls.Add(PbFoodMenu);
            SectionBasicInfo.Controls.Add(PbSelected);
            SectionBasicInfo.Dock = DockStyle.Top;
            SectionBasicInfo.Location = new Point(0, 127);
            SectionBasicInfo.Name = "SectionBasicInfo";
            SectionBasicInfo.Size = new Size(210, 56);
            SectionBasicInfo.TabIndex = 13;
            // 
            // lblFoodMenu
            // 
            lblFoodMenu.AutoSize = true;
            lblFoodMenu.BackColor = Color.White;
            lblFoodMenu.Location = new Point(41, 16);
            lblFoodMenu.Name = "lblFoodMenu";
            lblFoodMenu.Size = new Size(85, 25);
            lblFoodMenu.TabIndex = 16;
            lblFoodMenu.TabStop = true;
            lblFoodMenu.Text = "لیست غذاها";
            lblFoodMenu.MouseLeave += lblFoodMenu_MouseLeave;
            lblFoodMenu.MouseHover += lblFoodMenu_MouseHover;
            // 
            // PbFoodMenu
            // 
            PbFoodMenu.BackColor = Color.White;
            PbFoodMenu.BackgroundImageLayout = ImageLayout.Stretch;
            PbFoodMenu.Image = (Image)resources.GetObject("PbFoodMenu.Image");
            PbFoodMenu.Location = new Point(132, 8);
            PbFoodMenu.Name = "PbFoodMenu";
            PbFoodMenu.Size = new Size(39, 40);
            PbFoodMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            PbFoodMenu.TabIndex = 15;
            PbFoodMenu.TabStop = false;
            PbFoodMenu.MouseLeave += PbFoodMenu_MouseLeave;
            PbFoodMenu.MouseHover += PbFoodMenu_MouseHover;
            // 
            // PbSelected
            // 
            PbSelected.Dock = DockStyle.Top;
            PbSelected.Image = Properties.Resources.selected_back;
            PbSelected.Location = new Point(0, 0);
            PbSelected.Name = "PbSelected";
            PbSelected.Size = new Size(210, 56);
            PbSelected.TabIndex = 14;
            PbSelected.TabStop = false;
            // 
            // SectionHeaderBasicInfo
            // 
            SectionHeaderBasicInfo.BackColor = Color.FromArgb(255, 128, 128);
            SectionHeaderBasicInfo.Dock = DockStyle.Top;
            SectionHeaderBasicInfo.Location = new Point(0, 97);
            SectionHeaderBasicInfo.Name = "SectionHeaderBasicInfo";
            SectionHeaderBasicInfo.Size = new Size(210, 30);
            SectionHeaderBasicInfo.TabIndex = 11;
            SectionHeaderBasicInfo.TabStop = false;
            // 
            // SectionSignOut
            // 
            SectionSignOut.Controls.Add(lblSignOut);
            SectionSignOut.Controls.Add(PbSignOut);
            SectionSignOut.Dock = DockStyle.Bottom;
            SectionSignOut.Location = new Point(0, 660);
            SectionSignOut.Name = "SectionSignOut";
            SectionSignOut.Size = new Size(210, 49);
            SectionSignOut.TabIndex = 8;
            // 
            // lblSignOut
            // 
            lblSignOut.AutoSize = true;
            lblSignOut.Location = new Point(45, 19);
            lblSignOut.Name = "lblSignOut";
            lblSignOut.Size = new Size(95, 25);
            lblSignOut.TabIndex = 9;
            lblSignOut.TabStop = true;
            lblSignOut.Text = "خروج از برنامه";
            lblSignOut.LinkClicked += lblSignOut_LinkClicked;
            // 
            // PbSignOut
            // 
            PbSignOut.BackgroundImageLayout = ImageLayout.Stretch;
            PbSignOut.Image = (Image)resources.GetObject("PbSignOut.Image");
            PbSignOut.Location = new Point(146, 3);
            PbSignOut.Name = "PbSignOut";
            PbSignOut.Size = new Size(39, 41);
            PbSignOut.SizeMode = PictureBoxSizeMode.StretchImage;
            PbSignOut.TabIndex = 8;
            PbSignOut.TabStop = false;
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.Dock = DockStyle.Top;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(0, 0);
            Logo.Margin = new Padding(3, 5, 3, 5);
            Logo.Name = "Logo";
            Logo.Size = new Size(210, 97);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 4;
            Logo.TabStop = false;
            // 
            // Content
            // 
            Content.BackgroundImage = (Image)resources.GetObject("Content.BackgroundImage");
            Content.BackgroundImageLayout = ImageLayout.Stretch;
            Content.BorderStyle = BorderStyle.FixedSingle;
            Content.Dock = DockStyle.Fill;
            Content.Location = new Point(210, 43);
            Content.Name = "Content";
            Content.Size = new Size(862, 709);
            Content.TabIndex = 3;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 752);
            Controls.Add(Content);
            Controls.Add(RibbonBar);
            Margin = new Padding(3, 8, 3, 8);
            Name = "FrmMain";
            Text = "FrmMain";
            Load += FrmMain_Load;
            Controls.SetChildIndex(RibbonBar, 0);
            Controls.SetChildIndex(Content, 0);
            RibbonBar.ResumeLayout(false);
            RibbonBar.PerformLayout();
            SectionPayment.ResumeLayout(false);
            SectionPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbPayment).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            SectionBasicInfo.ResumeLayout(false);
            SectionBasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbFoodMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbSelected).EndInit();
            ((System.ComponentModel.ISupportInitialize)SectionHeaderBasicInfo).EndInit();
            SectionSignOut.ResumeLayout(false);
            SectionSignOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbSignOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel RibbonBar;
        private Panel Content;
        private Panel SectionSignOut;
        private LinkLabel lblSignOut;
        private PictureBox PbSignOut;
        private PictureBox SectionHeaderBasicInfo;
        private Panel SectionBasicInfo;
        private Panel SectionPayment;
        private LinkLabel lblPayment;
        private PictureBox PbPayment;
        private PictureBox pictureBox1;
        private Label lblBasicInfoHeader;
        private Label label1;
        private PictureBox Logo;
        private LinkLabel lblFoodMenu;
        private PictureBox PbFoodMenu;
        private PictureBox PbSelected;
    }
}