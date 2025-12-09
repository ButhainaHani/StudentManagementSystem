using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }
        public Student CreatedStudent { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
            try
            {
                string name = txtName.Text;
                int id = int.Parse(txtID.Text);
                int age = int.Parse(txtAge.Text);
                double gpa = double.Parse(txtGPA.Text);
                string faculty = txtFaculty.Text;

                CreatedStudent = new Student(name, id, age, gpa, faculty);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please enter valid data.");
            }
        }

    }
}

