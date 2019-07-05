using libRegEntity;
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
    public partial class FrmBornMonth : Form
    {
        public FrmBornMonth(List<PhysicalPerson> list)
        {
            InitializeComponent();
            this.PhysicalPersonBindingSource.DataSource = list;
        }

        private void FrmBornMonth_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
