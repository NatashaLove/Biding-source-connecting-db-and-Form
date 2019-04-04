namespace nlove_inclass07
{
    partial class Form2
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
            this.txtEnrollment = new System.Windows.Forms.TextBox();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.classroomDataSet = new nlove_inclass07.classroomDataSet();
            this.viewStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewStudentsTableAdapter = new nlove_inclass07.classroomDataSetTableAdapters.viewStudentsTableAdapter();
            this.viewClassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewClassesTableAdapter = new nlove_inclass07.classroomDataSetTableAdapters.viewClassesTableAdapter();
            this.gradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradesTableAdapter = new nlove_inclass07.classroomDataSetTableAdapters.GradesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.classroomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewClassesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEnrollment
            // 
            this.txtEnrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnrollment.Location = new System.Drawing.Point(340, 69);
            this.txtEnrollment.Name = "txtEnrollment";
            this.txtEnrollment.ReadOnly = true;
            this.txtEnrollment.Size = new System.Drawing.Size(188, 34);
            this.txtEnrollment.TabIndex = 0;
            // 
            // cmbStudent
            // 
            this.cmbStudent.DataSource = this.viewStudentsBindingSource;
            this.cmbStudent.DisplayMember = "Student_FullName";
            this.cmbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(340, 109);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(188, 39);
            this.cmbStudent.TabIndex = 1;
            this.cmbStudent.ValueMember = "Student_ID";
            // 
            // cmbGrade
            // 
            this.cmbGrade.DataSource = this.gradesBindingSource;
            this.cmbGrade.DisplayMember = "Grade_Name";
            this.cmbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(340, 199);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(188, 39);
            this.cmbGrade.TabIndex = 2;
            this.cmbGrade.ValueMember = "Grade_ID";
            // 
            // cmbClass
            // 
            this.cmbClass.DataSource = this.viewClassesBindingSource;
            this.cmbClass.DisplayMember = "Course_Name";
            this.cmbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(340, 154);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(188, 39);
            this.cmbClass.TabIndex = 3;
            this.cmbClass.ValueMember = "Class_ID";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(340, 244);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(188, 50);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enrollment ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Grade";
            // 
            // classroomDataSet
            // 
            this.classroomDataSet.DataSetName = "classroomDataSet";
            this.classroomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewStudentsBindingSource
            // 
            this.viewStudentsBindingSource.DataMember = "viewStudents";
            this.viewStudentsBindingSource.DataSource = this.classroomDataSet;
            // 
            // viewStudentsTableAdapter
            // 
            this.viewStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // viewClassesBindingSource
            // 
            this.viewClassesBindingSource.DataMember = "viewClasses";
            this.viewClassesBindingSource.DataSource = this.classroomDataSet;
            // 
            // viewClassesTableAdapter
            // 
            this.viewClassesTableAdapter.ClearBeforeFill = true;
            // 
            // gradesBindingSource
            // 
            this.gradesBindingSource.DataMember = "Grades";
            this.gradesBindingSource.DataSource = this.classroomDataSet;
            // 
            // gradesTableAdapter
            // 
            this.gradesTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.cmbGrade);
            this.Controls.Add(this.cmbStudent);
            this.Controls.Add(this.txtEnrollment);
            this.Name = "Form2";
            this.Opacity = 0.8D;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classroomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewClassesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnrollment;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private classroomDataSet classroomDataSet;
        private System.Windows.Forms.BindingSource viewStudentsBindingSource;
        private classroomDataSetTableAdapters.viewStudentsTableAdapter viewStudentsTableAdapter;
        private System.Windows.Forms.BindingSource viewClassesBindingSource;
        private classroomDataSetTableAdapters.viewClassesTableAdapter viewClassesTableAdapter;
        private System.Windows.Forms.BindingSource gradesBindingSource;
        private classroomDataSetTableAdapters.GradesTableAdapter gradesTableAdapter;
    }
}