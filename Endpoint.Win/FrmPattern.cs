using Endpoint.Win.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Endpoint.Win
{
    public partial class FrmPattern : Form
    {



        public FrmPattern()
        {
            InitializeComponent();

        }

        private string _frmTitle;
        public string FormTitle
        {
            get { return _frmTitle; }
            set
            {
                try
                {
                    _frmTitle = value;


                    Title.Text = _frmTitle;

                }
                catch
                {
                    return;
                }
            }
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture started by the mouse down.
                TitleBar.Capture = false; //select control

                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_MouseHover(object sender, EventArgs e)
        {
            BtnClose.Image = Resources.icons8_close_window_301;
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.BtnClose, "خروج");
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            BtnClose.Image = Resources.icons8_close_window_30;
        }

        private void BtnMinimize_MouseHover(object sender, EventArgs e)
        {
            BtnMinimize.Image = Resources.icons48_close_window_301;
        }

        private void BtnMinimize_MouseLeave(object sender, EventArgs e)
        {
            BtnMinimize.Image = Resources.icons48_close_window_30;

            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.BtnMinimize, "به‌ حداقل‌ رساندن‌");
        }
    }
}
