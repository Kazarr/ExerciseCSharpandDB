namespace Training
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.dsPerson = new System.Data.DataSet();
            this.colBusinessEntityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNationallDNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoginIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrganizationLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMartialStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalariedFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colVacationHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSickLeaveHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRowGuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEmployee = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBusinessEntityIDDataGridViewTextBoxColumn,
            this.colNationallDNumberDataGridViewTextBoxColumn,
            this.colLoginIdDataGridViewTextBoxColumn,
            this.colOrganizationLevelDataGridViewTextBoxColumn,
            this.colJobTitleDataGridViewTextBoxColumn,
            this.colBirthDateDataGridViewTextBoxColumn,
            this.colMartialStatusDataGridViewTextBoxColumn,
            this.colGenderDataGridViewTextBoxColumn,
            this.colHireDateDataGridViewTextBoxColumn,
            this.colSalariedFlagDataGridViewCheckBoxColumn,
            this.colVacationHoursDataGridViewTextBoxColumn,
            this.colSickLeaveHoursDataGridViewTextBoxColumn,
            this.colCurrentFlagDataGridViewCheckBoxColumn,
            this.colRowGuidDataGridViewTextBoxColumn,
            this.colModifiedDateDataGridViewTextBoxColumn});
            this.dgvEmployee.DataSource = this.bsEmployee;
            this.dgvEmployee.Location = new System.Drawing.Point(1, -7);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(528, 426);
            this.dgvEmployee.TabIndex = 0;
            // 
            // dgvPersons
            // 
            this.dgvPersons.AutoGenerateColumns = false;
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.DataSource = this.dsPerson;
            this.dgvPersons.Location = new System.Drawing.Point(738, 12);
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.Size = new System.Drawing.Size(528, 426);
            this.dgvPersons.TabIndex = 1;
            // 
            // dsPerson
            // 
            this.dsPerson.DataSetName = "NewDataSet";
            // 
            // colBusinessEntityIDDataGridViewTextBoxColumn
            // 
            this.colBusinessEntityIDDataGridViewTextBoxColumn.DataPropertyName = "BusinessEntityID";
            this.colBusinessEntityIDDataGridViewTextBoxColumn.HeaderText = "BusinessEntityID";
            this.colBusinessEntityIDDataGridViewTextBoxColumn.Name = "colBusinessEntityIDDataGridViewTextBoxColumn";
            // 
            // colNationallDNumberDataGridViewTextBoxColumn
            // 
            this.colNationallDNumberDataGridViewTextBoxColumn.DataPropertyName = "NationallDNumber";
            this.colNationallDNumberDataGridViewTextBoxColumn.HeaderText = "NationallDNumber";
            this.colNationallDNumberDataGridViewTextBoxColumn.Name = "colNationallDNumberDataGridViewTextBoxColumn";
            // 
            // colLoginIdDataGridViewTextBoxColumn
            // 
            this.colLoginIdDataGridViewTextBoxColumn.DataPropertyName = "LoginId";
            this.colLoginIdDataGridViewTextBoxColumn.HeaderText = "LoginId";
            this.colLoginIdDataGridViewTextBoxColumn.Name = "colLoginIdDataGridViewTextBoxColumn";
            // 
            // colOrganizationLevelDataGridViewTextBoxColumn
            // 
            this.colOrganizationLevelDataGridViewTextBoxColumn.DataPropertyName = "OrganizationLevel";
            this.colOrganizationLevelDataGridViewTextBoxColumn.HeaderText = "OrganizationLevel";
            this.colOrganizationLevelDataGridViewTextBoxColumn.Name = "colOrganizationLevelDataGridViewTextBoxColumn";
            // 
            // colJobTitleDataGridViewTextBoxColumn
            // 
            this.colJobTitleDataGridViewTextBoxColumn.DataPropertyName = "JobTitle";
            this.colJobTitleDataGridViewTextBoxColumn.HeaderText = "JobTitle";
            this.colJobTitleDataGridViewTextBoxColumn.Name = "colJobTitleDataGridViewTextBoxColumn";
            // 
            // colBirthDateDataGridViewTextBoxColumn
            // 
            this.colBirthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.colBirthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.colBirthDateDataGridViewTextBoxColumn.Name = "colBirthDateDataGridViewTextBoxColumn";
            // 
            // colMartialStatusDataGridViewTextBoxColumn
            // 
            this.colMartialStatusDataGridViewTextBoxColumn.DataPropertyName = "MartialStatus";
            this.colMartialStatusDataGridViewTextBoxColumn.HeaderText = "MartialStatus";
            this.colMartialStatusDataGridViewTextBoxColumn.Name = "colMartialStatusDataGridViewTextBoxColumn";
            // 
            // colGenderDataGridViewTextBoxColumn
            // 
            this.colGenderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.colGenderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.colGenderDataGridViewTextBoxColumn.Name = "colGenderDataGridViewTextBoxColumn";
            // 
            // colHireDateDataGridViewTextBoxColumn
            // 
            this.colHireDateDataGridViewTextBoxColumn.DataPropertyName = "HireDate";
            this.colHireDateDataGridViewTextBoxColumn.HeaderText = "HireDate";
            this.colHireDateDataGridViewTextBoxColumn.Name = "colHireDateDataGridViewTextBoxColumn";
            // 
            // colSalariedFlagDataGridViewCheckBoxColumn
            // 
            this.colSalariedFlagDataGridViewCheckBoxColumn.DataPropertyName = "SalariedFlag";
            this.colSalariedFlagDataGridViewCheckBoxColumn.HeaderText = "SalariedFlag";
            this.colSalariedFlagDataGridViewCheckBoxColumn.Name = "colSalariedFlagDataGridViewCheckBoxColumn";
            // 
            // colVacationHoursDataGridViewTextBoxColumn
            // 
            this.colVacationHoursDataGridViewTextBoxColumn.DataPropertyName = "VacationHours";
            this.colVacationHoursDataGridViewTextBoxColumn.HeaderText = "VacationHours";
            this.colVacationHoursDataGridViewTextBoxColumn.Name = "colVacationHoursDataGridViewTextBoxColumn";
            // 
            // colSickLeaveHoursDataGridViewTextBoxColumn
            // 
            this.colSickLeaveHoursDataGridViewTextBoxColumn.DataPropertyName = "SickLeaveHours";
            this.colSickLeaveHoursDataGridViewTextBoxColumn.HeaderText = "SickLeaveHours";
            this.colSickLeaveHoursDataGridViewTextBoxColumn.Name = "colSickLeaveHoursDataGridViewTextBoxColumn";
            // 
            // colCurrentFlagDataGridViewCheckBoxColumn
            // 
            this.colCurrentFlagDataGridViewCheckBoxColumn.DataPropertyName = "CurrentFlag";
            this.colCurrentFlagDataGridViewCheckBoxColumn.HeaderText = "CurrentFlag";
            this.colCurrentFlagDataGridViewCheckBoxColumn.Name = "colCurrentFlagDataGridViewCheckBoxColumn";
            // 
            // colRowGuidDataGridViewTextBoxColumn
            // 
            this.colRowGuidDataGridViewTextBoxColumn.DataPropertyName = "RowGuid";
            this.colRowGuidDataGridViewTextBoxColumn.HeaderText = "RowGuid";
            this.colRowGuidDataGridViewTextBoxColumn.Name = "colRowGuidDataGridViewTextBoxColumn";
            // 
            // colModifiedDateDataGridViewTextBoxColumn
            // 
            this.colModifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
            this.colModifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate";
            this.colModifiedDateDataGridViewTextBoxColumn.Name = "colModifiedDateDataGridViewTextBoxColumn";
            // 
            // bsEmployee
            // 
            this.bsEmployee.DataSource = typeof(Training.Employee);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(546, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(614, 5);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(29, 13);
            this.lblFilter.TabIndex = 3;
            this.lblFilter.Text = "Filter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 450);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvPersons);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.BindingSource bsEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBusinessEntityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNationallDNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoginIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrganizationNodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrganizationLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMartialStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSalariedFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVacationHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSickLeaveHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCurrentFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRowGuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModifiedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Data.DataSet dsPerson;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFilter;
    }
}

