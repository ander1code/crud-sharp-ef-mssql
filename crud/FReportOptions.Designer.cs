namespace crud
{
    partial class FrmReportOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportOptions));
            this.lblTitle = new System.Windows.Forms.Label();
            this.gpSalaryRange = new System.Windows.Forms.GroupBox();
            this.txtFinalInitial = new System.Windows.Forms.TextBox();
            this.lblFinal = new System.Windows.Forms.Label();
            this.txtInitialSal = new System.Windows.Forms.TextBox();
            this.lblInitial = new System.Windows.Forms.Label();
            this.gpBornMonth = new System.Windows.Forms.GroupBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.gpAVGSal = new System.Windows.Forms.GroupBox();
            this.cmbAVG = new System.Windows.Forms.ComboBox();
            this.gpBySalary = new System.Windows.Forms.GroupBox();
            this.cmbSal = new System.Windows.Forms.ComboBox();
            this.gpOptions = new System.Windows.Forms.GroupBox();
            this.rdAll = new System.Windows.Forms.RadioButton();
            this.rdBornMonth = new System.Windows.Forms.RadioButton();
            this.rdBySalary = new System.Windows.Forms.RadioButton();
            this.rdAverageWage = new System.Windows.Forms.RadioButton();
            this.rdSalaryRange = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.gpSalaryRange.SuspendLayout();
            this.gpBornMonth.SuspendLayout();
            this.gpAVGSal.SuspendLayout();
            this.gpBySalary.SuspendLayout();
            this.gpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Report Options";
            // 
            // gpSalaryRange
            // 
            this.gpSalaryRange.Controls.Add(this.txtFinalInitial);
            this.gpSalaryRange.Controls.Add(this.lblFinal);
            this.gpSalaryRange.Controls.Add(this.txtInitialSal);
            this.gpSalaryRange.Controls.Add(this.lblInitial);
            this.gpSalaryRange.Location = new System.Drawing.Point(15, 300);
            this.gpSalaryRange.Name = "gpSalaryRange";
            this.gpSalaryRange.Size = new System.Drawing.Size(320, 160);
            this.gpSalaryRange.TabIndex = 1;
            this.gpSalaryRange.TabStop = false;
            this.gpSalaryRange.Text = "Salary Range";
            // 
            // txtFinalInitial
            // 
            this.txtFinalInitial.Location = new System.Drawing.Point(10, 115);
            this.txtFinalInitial.Name = "txtFinalInitial";
            this.txtFinalInitial.Size = new System.Drawing.Size(300, 29);
            this.txtFinalInitial.TabIndex = 3;
            this.txtFinalInitial.TextChanged += new System.EventHandler(this.txtFinalInitial_TextChanged);
            this.txtFinalInitial.Enter += new System.EventHandler(this.txtFinalInitial_Enter);
            this.txtFinalInitial.Leave += new System.EventHandler(this.txtFinalInitial_Leave);
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(6, 88);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(119, 24);
            this.lblFinal.TabIndex = 2;
            this.lblFinal.Text = "Final Salary";
            // 
            // txtInitialSal
            // 
            this.txtInitialSal.Location = new System.Drawing.Point(10, 52);
            this.txtInitialSal.Name = "txtInitialSal";
            this.txtInitialSal.Size = new System.Drawing.Size(300, 29);
            this.txtInitialSal.TabIndex = 1;
            this.txtInitialSal.TextChanged += new System.EventHandler(this.txtInitialSal_TextChanged);
            this.txtInitialSal.Enter += new System.EventHandler(this.txtInitialSal_Enter);
            this.txtInitialSal.Leave += new System.EventHandler(this.txtInitialSal_Leave);
            // 
            // lblInitial
            // 
            this.lblInitial.AutoSize = true;
            this.lblInitial.Location = new System.Drawing.Point(6, 25);
            this.lblInitial.Name = "lblInitial";
            this.lblInitial.Size = new System.Drawing.Size(121, 24);
            this.lblInitial.TabIndex = 0;
            this.lblInitial.Text = "Initial Salary";
            // 
            // gpBornMonth
            // 
            this.gpBornMonth.Controls.Add(this.cmbMonth);
            this.gpBornMonth.Location = new System.Drawing.Point(15, 300);
            this.gpBornMonth.Name = "gpBornMonth";
            this.gpBornMonth.Size = new System.Drawing.Size(320, 100);
            this.gpBornMonth.TabIndex = 2;
            this.gpBornMonth.TabStop = false;
            this.gpBornMonth.Text = "Born in the Month";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(10, 52);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(300, 32);
            this.cmbMonth.TabIndex = 5;
            // 
            // gpAVGSal
            // 
            this.gpAVGSal.Controls.Add(this.cmbAVG);
            this.gpAVGSal.Location = new System.Drawing.Point(15, 300);
            this.gpAVGSal.Name = "gpAVGSal";
            this.gpAVGSal.Size = new System.Drawing.Size(320, 100);
            this.gpAVGSal.TabIndex = 3;
            this.gpAVGSal.TabStop = false;
            this.gpAVGSal.Text = "Average Wage";
            // 
            // cmbAVG
            // 
            this.cmbAVG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAVG.FormattingEnabled = true;
            this.cmbAVG.Items.AddRange(new object[] {
            "Above",
            "Equal",
            "Under",
            "",
            ""});
            this.cmbAVG.Location = new System.Drawing.Point(10, 52);
            this.cmbAVG.Name = "cmbAVG";
            this.cmbAVG.Size = new System.Drawing.Size(300, 32);
            this.cmbAVG.TabIndex = 5;
            // 
            // gpBySalary
            // 
            this.gpBySalary.Controls.Add(this.cmbSal);
            this.gpBySalary.Location = new System.Drawing.Point(15, 300);
            this.gpBySalary.Name = "gpBySalary";
            this.gpBySalary.Size = new System.Drawing.Size(320, 100);
            this.gpBySalary.TabIndex = 4;
            this.gpBySalary.TabStop = false;
            this.gpBySalary.Text = "Salary";
            // 
            // cmbSal
            // 
            this.cmbSal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSal.FormattingEnabled = true;
            this.cmbSal.Items.AddRange(new object[] {
            "Highest",
            "Lowest"});
            this.cmbSal.Location = new System.Drawing.Point(10, 52);
            this.cmbSal.Name = "cmbSal";
            this.cmbSal.Size = new System.Drawing.Size(300, 32);
            this.cmbSal.TabIndex = 5;
            // 
            // gpOptions
            // 
            this.gpOptions.Controls.Add(this.rdAll);
            this.gpOptions.Controls.Add(this.rdBornMonth);
            this.gpOptions.Controls.Add(this.rdBySalary);
            this.gpOptions.Controls.Add(this.rdAverageWage);
            this.gpOptions.Controls.Add(this.rdSalaryRange);
            this.gpOptions.Location = new System.Drawing.Point(15, 40);
            this.gpOptions.Name = "gpOptions";
            this.gpOptions.Size = new System.Drawing.Size(320, 250);
            this.gpOptions.TabIndex = 5;
            this.gpOptions.TabStop = false;
            this.gpOptions.Text = "Options";
            // 
            // rdAll
            // 
            this.rdAll.AutoSize = true;
            this.rdAll.Location = new System.Drawing.Point(44, 168);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(207, 28);
            this.rdAll.TabIndex = 4;
            this.rdAll.Text = "All Physical Person";
            this.rdAll.UseVisualStyleBackColor = true;
            this.rdAll.CheckedChanged += new System.EventHandler(this.rdAll_CheckedChanged);
            // 
            // rdBornMonth
            // 
            this.rdBornMonth.AutoSize = true;
            this.rdBornMonth.Location = new System.Drawing.Point(44, 134);
            this.rdBornMonth.Name = "rdBornMonth";
            this.rdBornMonth.Size = new System.Drawing.Size(194, 28);
            this.rdBornMonth.TabIndex = 3;
            this.rdBornMonth.Text = "Born in the Month";
            this.rdBornMonth.UseVisualStyleBackColor = true;
            this.rdBornMonth.CheckedChanged += new System.EventHandler(this.rdBornMonth_CheckedChanged);
            // 
            // rdBySalary
            // 
            this.rdBySalary.AutoSize = true;
            this.rdBySalary.Location = new System.Drawing.Point(44, 100);
            this.rdBySalary.Name = "rdBySalary";
            this.rdBySalary.Size = new System.Drawing.Size(114, 28);
            this.rdBySalary.TabIndex = 2;
            this.rdBySalary.Text = "By Salary";
            this.rdBySalary.UseVisualStyleBackColor = true;
            this.rdBySalary.CheckedChanged += new System.EventHandler(this.rdBySalary_CheckedChanged);
            // 
            // rdAverageWage
            // 
            this.rdAverageWage.AutoSize = true;
            this.rdAverageWage.Location = new System.Drawing.Point(44, 62);
            this.rdAverageWage.Name = "rdAverageWage";
            this.rdAverageWage.Size = new System.Drawing.Size(166, 28);
            this.rdAverageWage.TabIndex = 1;
            this.rdAverageWage.Text = "Average Wage";
            this.rdAverageWage.UseVisualStyleBackColor = true;
            this.rdAverageWage.CheckedChanged += new System.EventHandler(this.rdAverageWage_CheckedChanged);
            // 
            // rdSalaryRange
            // 
            this.rdSalaryRange.AutoSize = true;
            this.rdSalaryRange.Checked = true;
            this.rdSalaryRange.Location = new System.Drawing.Point(44, 28);
            this.rdSalaryRange.Name = "rdSalaryRange";
            this.rdSalaryRange.Size = new System.Drawing.Size(152, 28);
            this.rdSalaryRange.TabIndex = 0;
            this.rdSalaryRange.TabStop = true;
            this.rdSalaryRange.Text = "Salary Range";
            this.rdSalaryRange.UseVisualStyleBackColor = true;
            this.rdSalaryRange.CheckedChanged += new System.EventHandler(this.rdSalaryRange_CheckedChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Location = new System.Drawing.Point(16, 479);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(320, 30);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // FrmReportOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 516);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.gpOptions);
            this.Controls.Add(this.gpBySalary);
            this.Controls.Add(this.gpAVGSal);
            this.Controls.Add(this.gpBornMonth);
            this.Controls.Add(this.gpSalaryRange);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(370, 550);
            this.MinimumSize = new System.Drawing.Size(370, 550);
            this.Name = "FrmReportOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Options";
            this.Load += new System.EventHandler(this.FrmReportOptions_Load);
            this.gpSalaryRange.ResumeLayout(false);
            this.gpSalaryRange.PerformLayout();
            this.gpBornMonth.ResumeLayout(false);
            this.gpAVGSal.ResumeLayout(false);
            this.gpBySalary.ResumeLayout(false);
            this.gpOptions.ResumeLayout(false);
            this.gpOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gpSalaryRange;
        private System.Windows.Forms.TextBox txtFinalInitial;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.TextBox txtInitialSal;
        private System.Windows.Forms.Label lblInitial;
        private System.Windows.Forms.GroupBox gpBornMonth;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.GroupBox gpAVGSal;
        private System.Windows.Forms.ComboBox cmbAVG;
        private System.Windows.Forms.GroupBox gpBySalary;
        private System.Windows.Forms.ComboBox cmbSal;
        private System.Windows.Forms.GroupBox gpOptions;
        private System.Windows.Forms.RadioButton rdAll;
        private System.Windows.Forms.RadioButton rdBornMonth;
        private System.Windows.Forms.RadioButton rdBySalary;
        private System.Windows.Forms.RadioButton rdAverageWage;
        private System.Windows.Forms.RadioButton rdSalaryRange;
        private System.Windows.Forms.Button btnGenerate;
    }
}