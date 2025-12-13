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

        public AddStudentForm(Student existingStudent)
        {
            InitializeComponent();

            // اعرض البيانات في الفورم
            txtName.Text = existingStudent.Name;
            txtID.Text = existingStudent.ID.ToString();
            txtAge.Text = existingStudent.Age.ToString();
            txtGPA.Text = existingStudent.GPA.ToString();
            txtFaculty.Text = existingStudent.Faculty;

            // بحيث لو ضغط Save يتعدل نفس الطالب
            CreatedStudent = existingStudent;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
            try
            {
                string name = txtName.Text;
                int id = int.Parse(txtID.Text);
                int age = int.Parse(txtAge.Text);
                double gpa = double.Parse(txtGPA.Text);
                string faculty = txtFaculty.Text;

                if (CreatedStudent != null)
                {
                    CreatedStudent.Name = name;
                    CreatedStudent.ID = id;
                    CreatedStudent.Age = age;
                    CreatedStudent.GPA = gpa;
                    CreatedStudent.Faculty = faculty;
                }
                else
                {
                    // لو جديد
                    CreatedStudent = new Student(name, id, age, gpa, faculty);
                }
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
    }
}

