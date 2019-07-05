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
    public partial class FrmRegistration : Form
    {
        public int option_clear = 0;
        private int id;
        private FrmSearch frs = null;

        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            if (this.txtSalary.Text != String.Empty)
            {
                try
                {
                    Decimal.Parse(this.txtSalary.Text);
                }
                catch (Exception)
                {
                    this.txtSalary.Clear();
                }
            }
        }

        private void FRegistration_Load(object sender, EventArgs e)
        {
            SetIndex();
            if(this.frs != null)
            {
                this.frs.Dispose();
            }
            Clear();
        }
     
        private void Clear()
        {
            if (this.option_clear == 0)
            {
                this.txtName.Clear();
                this.txtEmail.Clear();
                this.txtSalary.Clear();
                this.dtDateBirth.Value = DateTime.Now.AddYears(-18);
                this.rdMale.Checked = true;
                this.btnInsert.Enabled = true;
                this.btnSearch.Enabled = true;
                this.btnClear.Enabled = true;
                this.btnEdit.Enabled = false;
                this.btnDelete.Enabled = false;
                this.id = 0;
            }
        }

        public void SetValue(int id, string name, string email, string salary, DateTime dateBirth, char genre)
        {
            this.id = id;
            this.txtName.Text = name;
            this.txtEmail.Text = email;
            this.txtSalary.Text = salary;
            this.dtDateBirth.Value = dateBirth;

            if (genre == 'M')
                this.rdMale.Checked = true;
            else
                this.rdFemale.Checked = true;
        }

        private void SetIndex()
        {
            this.txtName.TabIndex = 0;
            this.txtEmail.TabIndex = 1;
            this.txtSalary.TabIndex = 2;
            this.dtDateBirth.TabIndex = 3;
            this.rdMale.TabIndex = 4;
            this.rdFemale.TabIndex = 5;
            this.btnInsert.TabIndex = 6;
            this.btnSearch.TabIndex = 7;
            this.btnClear.TabIndex = 8;
            this.btnEdit.TabIndex = 9;
            this.btnDelete.TabIndex = 10;
        }

        public void SetPhysicalPerson(int id, String name, String email, Decimal salary, DateTime dateBirth, char genre, FrmSearch frs)
        {
            this.id = id;
            this.txtName.Text = name;
            this.txtEmail.Text = email;
            this.txtSalary.Text = salary.ToString();
            this.dtDateBirth.Value = dateBirth;
            if (genre == 'M')
                this.rdMale.Checked = true;
            else
                this.rdFemale.Checked = true;

            this.btnInsert.Enabled = false;
            this.btnEdit.Enabled = true;
            this.btnDelete.Enabled = true;
            frs.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want clear the form?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.option_clear = 0;
                this.Clear();
            }
        }

        private void dtDateBirth_Validated(object sender, EventArgs e)
        {
            if (this.dtDateBirth.Value > DateTime.Now.AddYears(-18))
            {
                MessageBox.Show("Date of Birth invalid.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.dtDateBirth.Value = DateTime.Now.AddYears(-18);
                this.dtDateBirth.Focus();
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            this.txtName.BackColor = Color.Yellow;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            this.txtName.BackColor = Color.White;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            this.txtEmail.BackColor = Color.Yellow;
        }

        private void txtSalary_Enter(object sender, EventArgs e)
        {
            this.txtSalary.BackColor = Color.Yellow;
        }

        private void dtDateBirth_Enter(object sender, EventArgs e)
        {
            this.dtDateBirth.BackColor = Color.Yellow;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            this.txtEmail.BackColor = Color.White;
        }

        private void txtSalary_Leave(object sender, EventArgs e)
        {
            this.txtSalary.BackColor = Color.White;
        }

        private void dtDateBirth_Leave(object sender, EventArgs e)
        {
            this.dtDateBirth.BackColor = Color.White;
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            if (!this.ValidateEmail(this.txtEmail.Text))
            {
                MessageBox.Show("Invalid email.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtEmail.Clear();
                this.txtEmail.Focus();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmSearch frm = new FrmSearch(this);
            frm.ShowDialog(this);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (InsertData() == 1)
            {
                MessageBox.Show("Physical Person successfully registered.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.option_clear = 0;
                this.Clear();
            }
        }

        private int InsertData()
        {
            if (this.txtName.Text == String.Empty)
            {
                MessageBox.Show("Name field is empty.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (this.txtEmail.Text == String.Empty)
            {
                MessageBox.Show("Email field is empty.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (this.txtSalary.Text == String.Empty)
            {
                MessageBox.Show("Salary field is empty.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            char genre;
            if (rdMale.Checked)
            {
                genre = 'M';
            }
            else
            {
                genre = 'F';
            }

            int return_op = Crud.Insert_PhysicalPerson(this.txtName.Text.Trim(), this.txtEmail.Text.Trim(), Decimal.Parse(this.txtSalary.Text), this.dtDateBirth.Value, genre);
            if (return_op == 1)
            {
                return return_op;
            }
            else
            {
                MessageBox.Show("Error registering Physical Person.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return return_op;
            }
        }


        private int EditData()
        {
            if (this.txtName.Text == String.Empty)
            {
                MessageBox.Show("Name field is empty.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (this.txtEmail.Text == String.Empty)
            {
                MessageBox.Show("Email field is empty.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (this.txtSalary.Text == String.Empty)
            {
                MessageBox.Show("Salary field is empty.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            char genre;
            if (rdMale.Checked)
            {
                genre = 'M';
            }
            else
            {
                genre = 'F';
            }

            int return_op = Crud.Edit_PhysicalPerson(this.id, this.txtName.Text.Trim(), this.txtEmail.Text.Trim(), Decimal.Parse(this.txtSalary.Text), this.dtDateBirth.Value, genre);
            if (return_op == 1)
            {
                return return_op;
            }
            else
            {
                MessageBox.Show("Error editing Physical Person record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return return_op;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (EditData() == 1)
            {
                MessageBox.Show("Physical Person successfully edited.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this record of Physical Person?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                if (Crud.Delete_PhysicalPerson(this.id) == 1)
                {
                    MessageBox.Show("Physical Person successfully deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.option_clear = 0;
                    this.Clear();
                }
                else
                {
                    MessageBox.Show("Error deleting Physical Person record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}
