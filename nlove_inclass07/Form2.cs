using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nlove_inclass07
{
    public partial class Form2 : Form
    {

        classroomDataSet ds; // copy of the database
        BindingSource bs; /// <summary>
        /// connects the database to the form
        /// </summary>


        public Form2(classroomDataSet d, BindingSource b)
        {
            InitializeComponent();
            ds = d;
            bs = b;

        }

       

        private void Form2_Load(object sender, EventArgs e)
        {
            //appeared because we added details in the form:

            // TODO: This line of code loads data into the 'classroomDataSet.Grades' table. You can move, or remove it, as needed.
            this.gradesTableAdapter.Fill(this.classroomDataSet.Grades);
            // TODO: This line of code loads data into the 'classroomDataSet.viewClasses' table. You can move, or remove it, as needed.
            this.viewClassesTableAdapter.Fill(this.classroomDataSet.viewClasses);
            // TODO: This line of code loads data into the 'classroomDataSet.viewStudents' table. You can move, or remove it, as needed.
            this.viewStudentsTableAdapter.Fill(this.classroomDataSet.viewStudents);

            txtEnrollment.DataBindings.Add("Text", bs, "Enrollment_ID");
            cmbStudent.DataBindings.Add("SelectedValue", bs, "Student_ID");
            cmbClass.DataBindings.Add("SelectedValue", bs, "Class_ID");
            cmbGrade.DataBindings.Add("SelectedValue", bs, "Grade_ID");

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bs.EndEdit();// closes connection between the form and the db
            classroomDataSetTableAdapters.EnrollmentsTableAdapter daEnrollment = new classroomDataSetTableAdapters.EnrollmentsTableAdapter();

            if (daEnrollment.Update(ds.Enrollments)>0)
            {
                MessageBox.Show("Updated");
                
            }
            else
            {
                MessageBox.Show("Whoops!");
            }

        }
    }
}
