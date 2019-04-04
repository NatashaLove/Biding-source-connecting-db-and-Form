using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using nlove_inclass07.classroomDataSetTableAdapters;

namespace nlove_inclass07
{
    public partial class Form1 : Form
    {
        classroomDataSet ds;
        viewStudentsTableAdapter daStudents;
        EnrollmentsTableAdapter daEnrollments;

        BindingSource bsStudents; // binding source always necessary between db (table) and the form -
        // into which we are trying to get info from the db - it's the connection/
        // can't transfer data directly from db into the form

        BindingSource bsEnrollments;


        public Form1() // constructor
        {
            InitializeComponent();

            ds = new classroomDataSet();
            daStudents = new viewStudentsTableAdapter();
            daEnrollments = new EnrollmentsTableAdapter();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            daStudents.Fill(ds.viewStudents);// form daStudents is filled with data from the table (db) viewStudents
            daEnrollments.Fill(ds.Enrollments);// -"-

            bsStudents = new BindingSource(ds, "viewStudents"); // bsStudents - becomes virtually a copy of the viewStudents db
            // just knows all the data - not yet looks the same
            bsEnrollments = new BindingSource(ds, "Enrollments");

            cmbStudent.DataSource = bsStudents; // where to take data from
            cmbStudent.DisplayMember = "Student_FullName";
            cmbStudent.ValueMember = "Student_ID";

            dgvEnrollments.DataSource = bsEnrollments;

            cmbStudent.SelectedValueChanged += cmbStudent_Changed;// control is added to event-handler manually


        }

        // method - event handler - manually writing
        private void cmbStudent_Changed(object sender, EventArgs e)
        {
            bsEnrollments.Filter = "Student_ID=" + (int)cmbStudent.SelectedValue;// it's all one line


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(ds, bsEnrollments);
            f.ShowDialog();

        }
    }
}
