
namespace DACN
{
    partial class AddByExcelForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.cboSheet = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.lecturerFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturerLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectureNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectureCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day1DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.day2DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.day3DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.day4DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.day5DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.day6DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.midtermScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.dACNDataSet1 = new DACN.DACNDataSet1();
            //this.classListTableAdapter = new DACN.DACNDataSet1TableAdapters.ClassListTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classListBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.dACNDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Controls.Add(this.cboSheet);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView4);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 745);
            this.panel1.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(237, 603);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(86, 23);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(90, 566);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(1062, 20);
            this.txtPath.TabIndex = 4;
            // 
            // cboSheet
            // 
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(90, 603);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(121, 21);
            this.cboSheet.TabIndex = 3;
            this.cboSheet.SelectedIndexChanged += new System.EventHandler(this.cboSheet_SelectedIndexChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(1158, 564);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 602);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sheet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Name:";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lecturerFirstNameDataGridViewTextBoxColumn,
            this.lecturerLastNameDataGridViewTextBoxColumn,
            this.mSGVDataGridViewTextBoxColumn,
            this.lectureNameDataGridViewTextBoxColumn,
            this.lectureCodeDataGridViewTextBoxColumn,
            this.studentFirstNameDataGridViewTextBoxColumn,
            this.studentLastNameDataGridViewTextBoxColumn,
            this.mSSVDataGridViewTextBoxColumn,
            this.day1DataGridViewCheckBoxColumn,
            this.day2DataGridViewCheckBoxColumn,
            this.day3DataGridViewCheckBoxColumn,
            this.day4DataGridViewCheckBoxColumn,
            this.day5DataGridViewCheckBoxColumn,
            this.day6DataGridViewCheckBoxColumn,
            this.midtermScoreDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.classListBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(1230, 546);
            this.dataGridView4.TabIndex = 0;
            // 
            // lecturerFirstNameDataGridViewTextBoxColumn
            // 
            this.lecturerFirstNameDataGridViewTextBoxColumn.DataPropertyName = "LecturerFirstName";
            this.lecturerFirstNameDataGridViewTextBoxColumn.HeaderText = "LecturerFirstName";
            this.lecturerFirstNameDataGridViewTextBoxColumn.Name = "lecturerFirstNameDataGridViewTextBoxColumn";
            this.lecturerFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lecturerLastNameDataGridViewTextBoxColumn
            // 
            this.lecturerLastNameDataGridViewTextBoxColumn.DataPropertyName = "LecturerLastName";
            this.lecturerLastNameDataGridViewTextBoxColumn.HeaderText = "LecturerLastName";
            this.lecturerLastNameDataGridViewTextBoxColumn.Name = "lecturerLastNameDataGridViewTextBoxColumn";
            this.lecturerLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mSGVDataGridViewTextBoxColumn
            // 
            this.mSGVDataGridViewTextBoxColumn.DataPropertyName = "MSGV";
            this.mSGVDataGridViewTextBoxColumn.HeaderText = "MSGV";
            this.mSGVDataGridViewTextBoxColumn.Name = "mSGVDataGridViewTextBoxColumn";
            this.mSGVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lectureNameDataGridViewTextBoxColumn
            // 
            this.lectureNameDataGridViewTextBoxColumn.DataPropertyName = "LectureName";
            this.lectureNameDataGridViewTextBoxColumn.HeaderText = "LectureName";
            this.lectureNameDataGridViewTextBoxColumn.Name = "lectureNameDataGridViewTextBoxColumn";
            this.lectureNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lectureCodeDataGridViewTextBoxColumn
            // 
            this.lectureCodeDataGridViewTextBoxColumn.DataPropertyName = "LectureCode";
            this.lectureCodeDataGridViewTextBoxColumn.HeaderText = "LectureCode";
            this.lectureCodeDataGridViewTextBoxColumn.Name = "lectureCodeDataGridViewTextBoxColumn";
            this.lectureCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentFirstNameDataGridViewTextBoxColumn
            // 
            this.studentFirstNameDataGridViewTextBoxColumn.DataPropertyName = "StudentFirstName";
            this.studentFirstNameDataGridViewTextBoxColumn.HeaderText = "StudentFirstName";
            this.studentFirstNameDataGridViewTextBoxColumn.Name = "studentFirstNameDataGridViewTextBoxColumn";
            this.studentFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentLastNameDataGridViewTextBoxColumn
            // 
            this.studentLastNameDataGridViewTextBoxColumn.DataPropertyName = "StudentLastName";
            this.studentLastNameDataGridViewTextBoxColumn.HeaderText = "StudentLastName";
            this.studentLastNameDataGridViewTextBoxColumn.Name = "studentLastNameDataGridViewTextBoxColumn";
            this.studentLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mSSVDataGridViewTextBoxColumn
            // 
            this.mSSVDataGridViewTextBoxColumn.DataPropertyName = "MSSV";
            this.mSSVDataGridViewTextBoxColumn.HeaderText = "MSSV";
            this.mSSVDataGridViewTextBoxColumn.Name = "mSSVDataGridViewTextBoxColumn";
            this.mSSVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // day1DataGridViewCheckBoxColumn
            // 
            this.day1DataGridViewCheckBoxColumn.DataPropertyName = "Day1";
            this.day1DataGridViewCheckBoxColumn.HeaderText = "Day1";
            this.day1DataGridViewCheckBoxColumn.Name = "day1DataGridViewCheckBoxColumn";
            this.day1DataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // day2DataGridViewCheckBoxColumn
            // 
            this.day2DataGridViewCheckBoxColumn.DataPropertyName = "Day2";
            this.day2DataGridViewCheckBoxColumn.HeaderText = "Day2";
            this.day2DataGridViewCheckBoxColumn.Name = "day2DataGridViewCheckBoxColumn";
            this.day2DataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // day3DataGridViewCheckBoxColumn
            // 
            this.day3DataGridViewCheckBoxColumn.DataPropertyName = "Day3";
            this.day3DataGridViewCheckBoxColumn.HeaderText = "Day3";
            this.day3DataGridViewCheckBoxColumn.Name = "day3DataGridViewCheckBoxColumn";
            this.day3DataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // day4DataGridViewCheckBoxColumn
            // 
            this.day4DataGridViewCheckBoxColumn.DataPropertyName = "Day4";
            this.day4DataGridViewCheckBoxColumn.HeaderText = "Day4";
            this.day4DataGridViewCheckBoxColumn.Name = "day4DataGridViewCheckBoxColumn";
            this.day4DataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // day5DataGridViewCheckBoxColumn
            // 
            this.day5DataGridViewCheckBoxColumn.DataPropertyName = "Day5";
            this.day5DataGridViewCheckBoxColumn.HeaderText = "Day5";
            this.day5DataGridViewCheckBoxColumn.Name = "day5DataGridViewCheckBoxColumn";
            this.day5DataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // day6DataGridViewCheckBoxColumn
            // 
            this.day6DataGridViewCheckBoxColumn.DataPropertyName = "Day6";
            this.day6DataGridViewCheckBoxColumn.HeaderText = "Day6";
            this.day6DataGridViewCheckBoxColumn.Name = "day6DataGridViewCheckBoxColumn";
            this.day6DataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // midtermScoreDataGridViewTextBoxColumn
            // 
            this.midtermScoreDataGridViewTextBoxColumn.DataPropertyName = "MidtermScore";
            this.midtermScoreDataGridViewTextBoxColumn.HeaderText = "MidtermScore";
            this.midtermScoreDataGridViewTextBoxColumn.Name = "midtermScoreDataGridViewTextBoxColumn";
            this.midtermScoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classListBindingSource
            // 
            this.classListBindingSource.DataMember = "ClassList";
            //this.classListBindingSource.DataSource = this.dACNDataSet1;
            // 
            // dACNDataSet1
            // 
            //this.dACNDataSet1.DataSetName = "DACNDataSet1";
            //this.dACNDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classListTableAdapter
            // 
            //this.classListTableAdapter.ClearBeforeFill = true;
            // 
            // AddByExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 746);
            this.Controls.Add(this.panel1);
            this.Name = "AddByExcelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddByExcelForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classListBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.dACNDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ComboBox cboSheet;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImport;
        //private DACNDataSet1 dACNDataSet1;
        private System.Windows.Forms.BindingSource classListBindingSource;
        //private DACNDataSet1TableAdapters.ClassListTableAdapter classListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturerFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturerLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn day1DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn day2DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn day3DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn day4DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn day5DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn day6DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midtermScoreDataGridViewTextBoxColumn;
    }
}