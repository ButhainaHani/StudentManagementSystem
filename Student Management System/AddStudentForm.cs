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
        public AddStudentForm(Student s)
        {
            InitializeComponent();

            txtName.Text = s.Name;
            txtID.Text = s.ID.ToString();
            txtAge.Text = s.Age.ToString();
            txtGPA.Text = s.GPA.ToString();
            txtFaculty.Text = s.Faculty;

            txtID.ReadOnly = true; // ID must not change
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

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void txtGPA_TextChanged(object sender, EventArgs e)
        {
            //..
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

