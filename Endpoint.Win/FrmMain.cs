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
    public partial class FrmMain : FrmPattern

    {
        public FrmMain()
        {
            InitializeComponent();
            this.FormTitle = "چنگال [فرم اصلی]";
            this.WindowState = FormWindowState.Maximized;

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void lblSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void PbFoodMenu_MouseHover(object sender, EventArgs e)
        {
            PbSelected.Image = Resources.selected_back2;
        }

        private void PbFoodMenu_MouseLeave(object sender, EventArgs e)
        {
            PbSelected.Image = Resources.selected_back;
        }

        private void lblFoodMenu_MouseHover(object sender, EventArgs e)
        {
            PbSelected.Image = Resources.selected_back2;
        }

        private void lblFoodMenu_MouseLeave(object sender, EventArgs e)
        {
            PbSelected.Image = Resources.selected_back;
        }
    }
}
