namespace Endpoint.Win
{
    partial class FrmPattern
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
            TitleBar = new Panel();
            BtnMinimize = new PictureBox();
            Title = new Label();
            BtnClose = new PictureBox();
            TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            SuspendLayout();
            // 
            // TitleBar
            // 
            TitleBar.BackColor = SystemColors.ActiveCaption;
            TitleBar.Controls.Add(BtnMinimize);
            TitleBar.Controls.Add(Title);
            TitleBar.Controls.Add(BtnClose);
            TitleBar.Dock = DockStyle.Top;
            TitleBar.Location = new Point(0, 0);
            TitleBar.Margin = new Padding(3, 4, 3, 4);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(574, 43);
            TitleBar.TabIndex = 0;
            TitleBar.MouseDown += TitleBar_MouseDown;
            // 
            // BtnMinimize
            // 
            BtnMinimize.Cursor = Cursors.Hand;
            BtnMinimize.Dock = DockStyle.Right;
            BtnMinimize.Image = Properties.Resources.icons48_close_window_30;
            BtnMinimize.Location = new Point(512, 0);
            BtnMinimize.Margin = new Padding(3, 4, 3, 4);
            BtnMinimize.Name = "BtnMinimize";
            BtnMinimize.Size = new Size(31, 43);
            BtnMinimize.TabIndex = 2;
            BtnMinimize.TabStop = false;
            BtnMinimize.Click += BtnMinimize_Click;
            BtnMinimize.MouseLeave += BtnMinimize_MouseLeave;
            BtnMinimize.MouseHover += BtnMinimize_MouseHover;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Dock = DockStyle.Left;
            Title.ForeColor = SystemColors.Control;
            Title.Location = new Point(0, 0);
            Title.Name = "Title";
            Title.Size = new Size(85, 25);
            Title.TabIndex = 1;
            Title.Text = "Form Title";
            // 
            // BtnClose
            // 
            BtnClose.Cursor = Cursors.Hand;
            BtnClose.Dock = DockStyle.Right;
            BtnClose.Image = Properties.Resources.icons8_close_window_30;
            BtnClose.Location = new Point(543, 0);
            BtnClose.Margin = new Padding(3, 4, 3, 4);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(31, 43);
            BtnClose.TabIndex = 0;
            BtnClose.TabStop = false;
            BtnClose.Click += BtnClose_Click;
            BtnClose.MouseLeave += BtnClose_MouseLeave;
            BtnClose.MouseHover += BtnClose_MouseHover;
            // 
            // FrmPattern
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 291);
            Controls.Add(TitleBar);
            Font = new Font("IRANSans(FaNum)", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 7, 3, 7);
            Name = "FrmPattern";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPattern";
            TitleBar.ResumeLayout(false);
            TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel TitleBar;
        private PictureBox BtnClose;
        private Label Title;
        private PictureBox BtnMinimize;
    }
}