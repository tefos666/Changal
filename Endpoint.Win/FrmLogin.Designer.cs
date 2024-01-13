namespace Endpoint.Win
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            lblUserName = new Label();
            lblPassword = new Label();
            TxtUserName = new TextBox();
            TxtPassword = new TextBox();
            Logo = new PictureBox();
            BtnLogin = new Button();
            lblTips = new Label();
            pnlAppName = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            pnlAppName.SuspendLayout();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("IRANSans(FaNum)", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.Location = new Point(18, 221);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(70, 22);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "نام کاربری :";
            lblUserName.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("IRANSans(FaNum)", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(18, 272);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(54, 22);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "گذرواژه :";
            lblPassword.TextAlign = ContentAlignment.TopCenter;
            // 
            // TxtUserName
            // 
            TxtUserName.Location = new Point(94, 216);
            TxtUserName.Margin = new Padding(3, 5, 3, 5);
            TxtUserName.Name = "TxtUserName";
            TxtUserName.Size = new Size(236, 33);
            TxtUserName.TabIndex = 1;
            TxtUserName.Enter += TxtUserName_Enter;
            TxtUserName.Leave += TxtUserName_Leave;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(94, 272);
            TxtPassword.Margin = new Padding(3, 5, 3, 5);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(236, 33);
            TxtPassword.TabIndex = 2;
            TxtPassword.Enter += TxtPassword_Enter;
            TxtPassword.Leave += TxtPassword_Leave;
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(274, 9);
            Logo.Margin = new Padding(3, 5, 3, 5);
            Logo.Name = "Logo";
            Logo.Size = new Size(202, 97);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 3;
            Logo.TabStop = false;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.LightGray;
            BtnLogin.Font = new Font("IRANSans(FaNum)", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLogin.Location = new Point(365, 264);
            BtnLogin.Margin = new Padding(3, 5, 3, 5);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(71, 41);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "ورود";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            BtnLogin.MouseLeave += BtnLogin_MouseLeave;
            BtnLogin.MouseHover += BtnLogin_MouseHover;
            // 
            // lblTips
            // 
            lblTips.AutoSize = true;
            lblTips.Location = new Point(12, 180);
            lblTips.Name = "lblTips";
            lblTips.Size = new Size(366, 25);
            lblTips.TabIndex = 5;
            lblTips.Text = "لطفا جهت ورود به سیستم نام کاربری و گذرواژه را وارد نمایید";
            // 
            // pnlAppName
            // 
            pnlAppName.BackColor = Color.SkyBlue;
            pnlAppName.Controls.Add(label3);
            pnlAppName.Controls.Add(label2);
            pnlAppName.Controls.Add(label1);
            pnlAppName.Controls.Add(Logo);
            pnlAppName.Dock = DockStyle.Top;
            pnlAppName.Location = new Point(0, 43);
            pnlAppName.Name = "pnlAppName";
            pnlAppName.Size = new Size(522, 112);
            pnlAppName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 70);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 8;
            label3.Text = "Changal.app";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 20);
            label2.Name = "label2";
            label2.Size = new Size(201, 25);
            label2.TabIndex = 7;
            label2.Text = "نرم افزار مدیریت رستوران چنگال";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 45);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 6;
            label1.Text = "نگارش اول - دیماه 1402";
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.LightGray;
            BtnExit.Font = new Font("IRANSans(FaNum)", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExit.Location = new Point(445, 263);
            BtnExit.Margin = new Padding(3, 5, 3, 5);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(71, 41);
            BtnExit.TabIndex = 4;
            BtnExit.Text = "انصراف";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            BtnExit.MouseLeave += BtnExit_MouseLeave_1;
            BtnExit.MouseHover += BtnExit_MouseHover;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(522, 318);
            ControlBox = false;
            Controls.Add(pnlAppName);
            Controls.Add(lblTips);
            Controls.Add(BtnExit);
            Controls.Add(BtnLogin);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUserName);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Margin = new Padding(3, 8, 3, 8);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            ShowIcon = false;
            Text = " jh";
            Controls.SetChildIndex(lblUserName, 0);
            Controls.SetChildIndex(lblPassword, 0);
            Controls.SetChildIndex(TxtUserName, 0);
            Controls.SetChildIndex(TxtPassword, 0);
            Controls.SetChildIndex(BtnLogin, 0);
            Controls.SetChildIndex(BtnExit, 0);
            Controls.SetChildIndex(lblTips, 0);
            Controls.SetChildIndex(pnlAppName, 0);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            pnlAppName.ResumeLayout(false);
            pnlAppName.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUserName;
        private Label lblPassword;
        private TextBox TxtUserName;
        private TextBox TxtPassword;
        private PictureBox Logo;
        private Button BtnLogin;
        private Label lblTips;
        private Panel pnlAppName;
        private Button BtnExit;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}