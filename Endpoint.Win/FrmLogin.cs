using Changal.Infra;
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
    public partial class FrmLogin : FrmPattern
    {
        public FrmLogin()
        {
            InitializeComponent();
            FormTitle = "چنگال [فرم ورود]";
        }



        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            BtnLogin.BackColor = Color.LightGray;
        }



        private void BtnLogin_MouseHover(object sender, EventArgs e)
        {
            BtnLogin.BackColor = Color.SkyBlue;
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExit_MouseHover(object sender, EventArgs e)
        {
            BtnExit.BackColor = Color.SkyBlue;
        }

        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            BtnExit.BackColor = Color.Red;
        }

        private void TxtUserName_Enter(object sender, EventArgs e)
        {
            TxtUserName.BackColor = Color.AntiqueWhite;
        }

        private void TxtUserName_Leave(object sender, EventArgs e)
        {
            TxtUserName.BackColor = Color.White;
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            TxtPassword.BackColor = Color.AntiqueWhite;
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            TxtPassword.BackColor = Color.White;
        }

        private void BtnExit_MouseLeave_1(object sender, EventArgs e)
        {
            BtnExit.BackColor = Color.LightGray;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            ILog log = new SaveToFile();
            log.Log("Login OK |  1402~10~25  | Admin ");
            this.Hide();
            FrmMain frm = new FrmMain();
            frm.ShowDialog();



            /*
            this.SetTopLevel=true;
            this.HasChildren = true;
            this.Parent = ....;
            */
        }
    }
}
