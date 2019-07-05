using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace crud
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void FrmSplash_Shown(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            FrmLogin fl = new FrmLogin();
            this.Visible = false;
            fl.ShowDialog(this);
        }
    }
}
