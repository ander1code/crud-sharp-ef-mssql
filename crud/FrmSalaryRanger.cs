using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using libRegEntity;

namespace crud
{
    public partial class FrmAverageWaze : Form
    {
        public FrmAverageWaze(List<PhysicalPerson> list)
        {
            InitializeComponent();
            this.PhysicalPersonBindingSource.DataSource = list;
        }

        private void FrmSalaryRanger_Load(object sender, EventArgs e)
        {
            this.reportViewer.RefreshReport();
        }
    }
}
