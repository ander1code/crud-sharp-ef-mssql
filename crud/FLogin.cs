using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using libRegEntity;
using System.Threading;

namespace crud
{
    public partial class FrmLogin : Form
    {
        private FrmSplash fs;
        private int statusClose = 0;

        public FrmLogin()
        {
            InitializeComponent();
        }
        
        public FrmLogin(FrmSplash fs)
        {
            this.fs = fs;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.txtUser.Text = "Admin";
            this.txtPass.Text = "admin";
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            this.txtUser.BackColor = Color.Yellow;
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            this.txtUser.BackColor = Color.White;
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            this.txtPass.BackColor = Color.Yellow;
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            this.txtPass.BackColor = Color.White;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = this.txtUser.Text.Trim();
            String userpass = this.txtPass.Text.Trim();
            //if(Crud.ToLog_UserSys(username, userpass) == 1)
            if(true)
            {
                FrmPrincipal fp = new FrmPrincipal(this);
                this.statusClose = 1;
                fp.Show();
            }
            else
            {
                MessageBox.Show("User does not exist in the system.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
      
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.statusClose == 0)
            {
                DialogResult result = MessageBox.Show("Do You want to leave the system?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (result)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        Environment.Exit(0);
                        break;
                    case System.Windows.Forms.DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
