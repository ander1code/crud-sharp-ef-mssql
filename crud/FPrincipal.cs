using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace crud
{
    public partial class FrmPrincipal : Form
    {
        private FrmLogin fl;
        
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public FrmPrincipal(FrmLogin fl)
        {
            InitializeComponent();
            this.fl = fl;
            this.fl.Visible = false;
            CreateStatusBar();
        }

        public void CreateStatusBar()
        {
            StatusBar statusBar1 = new StatusBar();
	        StatusBarPanel panel1 = new StatusBarPanel();
	        StatusBarPanel panel2 = new StatusBarPanel();

	        panel1.BorderStyle = StatusBarPanelBorderStyle.Sunken;
            panel1.Text = "User Logged:" + " " + fl.TxtUser.Text;
            panel1.Alignment = HorizontalAlignment.Left;
	        panel1.AutoSize = StatusBarPanelAutoSize.Spring;

            panel2.BorderStyle = StatusBarPanelBorderStyle.Sunken;
            panel2.Text = "DateTime:" + " " + DateTime.Now;
            panel2.Alignment = HorizontalAlignment.Right;
            panel2.AutoSize = StatusBarPanelAutoSize.Spring;

	        statusBar1.ShowPanels = true;

	        statusBar1.Panels.Add(panel1);
	        statusBar1.Panels.Add(panel2);

	        this.Controls.Add(statusBar1);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRegistration frm = new FrmRegistration();
            frm.ShowDialog(this);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSearch fs = new FrmSearch();
            fs.ShowDialog(this);
        }
    
        private void FrmPrincipal_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info; //Shows the info icon so the user doesn't thing there is an error.
                this.notifyIcon.BalloonTipText = "The system is still active.";
                this.notifyIcon.BalloonTipTitle = "Registration System";
                this.notifyIcon.Icon = new Icon("gear.ico");
                this.notifyIcon.Text = "Registration System";
                notifyIcon.ShowBalloonTip(3000);
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.ShowInTaskbar = true;
            notifyIcon.Visible = false;
        }
  
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to leave the system?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case System.Windows.Forms.DialogResult.Yes:
                    Environment.Exit(0);
                    break;
                case System.Windows.Forms.DialogResult.No:
                    e.Cancel = true;
                    this.WindowState = FormWindowState.Minimized;
                    this.ShowInTaskbar = false;
                    notifyIcon.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportOptions fro = new FrmReportOptions();
            fro.ShowDialog(this);
        }
    }
}
