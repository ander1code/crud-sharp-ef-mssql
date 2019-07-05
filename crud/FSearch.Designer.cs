namespace crud
{
    partial class FrmSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearch));
            this.label1 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtDataSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdCode = new System.Windows.Forms.RadioButton();
            this.rdName = new System.Windows.Forms.RadioButton();
            this.GridPhysicalPerson = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridPhysicalPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 92);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(129, 24);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data Search:";
            // 
            // txtDataSearch
            // 
            this.txtDataSearch.Location = new System.Drawing.Point(16, 119);
            this.txtDataSearch.Name = "txtDataSearch";
            this.txtDataSearch.Size = new System.Drawing.Size(440, 29);
            this.txtDataSearch.TabIndex = 2;
            this.txtDataSearch.TextChanged += new System.EventHandler(this.txtDataSearch_TextChanged);
            this.txtDataSearch.Enter += new System.EventHandler(this.txtDataSearch_Enter);
            this.txtDataSearch.Leave += new System.EventHandler(this.txtDataSearch_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(466, 119);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdCode
            // 
            this.rdCode.AutoSize = true;
            this.rdCode.Location = new System.Drawing.Point(556, 60);
            this.rdCode.Name = "rdCode";
            this.rdCode.Size = new System.Drawing.Size(116, 28);
            this.rdCode.TabIndex = 5;
            this.rdCode.Text = "For Code";
            this.rdCode.UseVisualStyleBackColor = true;
            this.rdCode.CheckedChanged += new System.EventHandler(this.rdCode_CheckedChanged);
            this.rdCode.Click += new System.EventHandler(this.rdCode_Click);
            // 
            // rdName
            // 
            this.rdName.AutoSize = true;
            this.rdName.Checked = true;
            this.rdName.Location = new System.Drawing.Point(429, 60);
            this.rdName.Name = "rdName";
            this.rdName.Size = new System.Drawing.Size(121, 28);
            this.rdName.TabIndex = 6;
            this.rdName.TabStop = true;
            this.rdName.Text = "For Name";
            this.rdName.UseVisualStyleBackColor = true;
            this.rdName.CheckedChanged += new System.EventHandler(this.rdName_CheckedChanged);
            this.rdName.Click += new System.EventHandler(this.rdName_Click);
            // 
            // GridPhysicalPerson
            // 
            this.GridPhysicalPerson.AllowUserToAddRows = false;
            this.GridPhysicalPerson.AllowUserToDeleteRows = false;
            this.GridPhysicalPerson.AllowUserToResizeColumns = false;
            this.GridPhysicalPerson.AllowUserToResizeRows = false;
            this.GridPhysicalPerson.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPhysicalPerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridPhysicalPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPhysicalPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.dateBirth,
            this.email,
            this.salary,
            this.genre});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridPhysicalPerson.DefaultCellStyle = dataGridViewCellStyle4;
            this.GridPhysicalPerson.Location = new System.Drawing.Point(16, 154);
            this.GridPhysicalPerson.MultiSelect = false;
            this.GridPhysicalPerson.Name = "GridPhysicalPerson";
            this.GridPhysicalPerson.ReadOnly = true;
            this.GridPhysicalPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPhysicalPerson.Size = new System.Drawing.Size(650, 440);
            this.GridPhysicalPerson.TabIndex = 7;
            this.GridPhysicalPerson.Visible = false;
            this.GridPhysicalPerson.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPhysicalPerson_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.DefaultCellStyle = dataGridViewCellStyle2;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.Width = 400;
            // 
            // dateBirth
            // 
            this.dateBirth.DataPropertyName = "dateBirth";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dateBirth.DefaultCellStyle = dataGridViewCellStyle3;
            this.dateBirth.HeaderText = "Date Birth";
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.ReadOnly = true;
            this.dateBirth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dateBirth.Width = 205;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            // 
            // salary
            // 
            this.salary.DataPropertyName = "salary";
            this.salary.HeaderText = "Salary";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            this.salary.Visible = false;
            // 
            // genre
            // 
            this.genre.DataPropertyName = "genre";
            this.genre.HeaderText = "Genre";
            this.genre.Name = "genre";
            this.genre.ReadOnly = true;
            this.genre.Visible = false;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(674, 602);
            this.Controls.Add(this.GridPhysicalPerson);
            this.Controls.Add(this.rdName);
            this.Controls.Add(this.rdCode);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDataSearch);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(690, 640);
            this.MinimumSize = new System.Drawing.Size(690, 640);
            this.Name = "FrmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.txtDataSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPhysicalPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtDataSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdCode;
        private System.Windows.Forms.RadioButton rdName;
        private System.Windows.Forms.DataGridView GridPhysicalPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
    }
}