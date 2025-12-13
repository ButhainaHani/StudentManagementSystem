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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // LinkedList لكل الطلاب
        StudentLinkedList students = new StudentLinkedList();

        // Priority Queue للطلاب حسب GPA
        StudentPriorityQueue serviceQueue = new StudentPriorityQueue();
        StudentPriorityQueue priorityQueue = new StudentPriorityQueue();

        // ===============================
        //  تحديث عرض جميع الطلاب في DataGridView
        // ===============================
        private void RefreshGrid()
        {
            dataGridView1.Rows.Clear();

            var list = students.ToList();
            foreach (var s in list)
            {
                dataGridView1.Rows.Add(s.Name, s.ID, s.Age, s.GPA, s.Faculty);
            }
        }

        // دالة مساعدة للحصول على كل الطلاب
        private List<Student> GetAllStudents()
        {
            return students.ToList();
        }

        // عرض قائمة معينة من الطلاب في DataGridView
        private void ShowStudentsInGrid(List<Student> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var st in list)
            {
                dataGridView1.Rows.Add(st.Name, st.ID, st.Age, st.GPA, st.Faculty);
            }
        }

        // ===============================
        //  إضافة طالب جديد
        // ===============================
        //jj
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudentForm addForm = new AddStudentForm();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // إضافة الطالب للـ LinkedList
                students.Add(addForm.CreatedStudent);

                // إضافة الطالب للكيو حسب الأولوية
                serviceQueue.Enqueue(addForm.CreatedStudent);

                RefreshGrid();
            }
        }

        // ===============================
        //  البحث في جميع الحقول
        // ===============================
        private List<Student> LinearSearchAllFields(string query)
        {
            var results = new List<Student>();
            if (string.IsNullOrWhiteSpace(query)) return results;

            query = query.Trim();
            var list = GetAllStudents();

            foreach (var st in list)
            {
                bool match = false;

                if (!string.IsNullOrEmpty(st.Name) &&
                    st.Name.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                    match = true;

                if (!match && st.ID.ToString().Contains(query))
                    match = true;

                if (!match && st.Age.ToString().Contains(query))
                    match = true;

                if (!match && st.GPA.ToString().Contains(query))
                    match = true;

                if (!match && !string.IsNullOrEmpty(st.Faculty) &&
                    st.Faculty.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                    match = true;

                if (match) results.Add(st);
            }

            return results;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearchId.Text;

            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Please enter a search value.");
                return;
            }

            var results = LinearSearchAllFields(query);

            if (results.Count == 0)
            {
                MessageBox.Show("No results found.");
                return;
            }

            ShowStudentsInGrid(results);
        }

        // ===============================
        //  الترتيب
        // ===============================
        private void button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnSort, 0, btnSort.Height);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            students.SortByName();
            RefreshGrid();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            students.SortByID();
            RefreshGrid();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            students.SortByAge();
            RefreshGrid();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            students.SortByGPA();
            RefreshGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ===============================
        //  الكيو: عرض الطلاب في DataGridView آخر
        // ===============================
        private void RefreshQueueGrid()
        {
            dataGridViewQueue.Rows.Clear();
            var queueList = serviceQueue.DisplayQueue();

            foreach (var s in queueList)
            {
                dataGridViewQueue.Rows.Add(s.ID, s.Name, s.GPA, s.Faculty);
            }
        }

        private void btnShowQueue_Click(object sender, EventArgs e)
        {
            RefreshQueueGrid();
        }

        // ===============================
        //  خدمة الطالب ذو الأولوية الأعلى
        // ===============================
        private void btnServeStudent_Click(object sender, EventArgs e)
        {
            Student servedStudent = serviceQueue.Dequeue();

            if (servedStudent != null)
            {
                MessageBox.Show($"Student {servedStudent.Name} with GPA {servedStudent.GPA} is being served!");
                RefreshQueueGrid(); // تحديث عرض الكيو
            }
            else
            {
                MessageBox.Show("No students in queue.");
            }
        }

        private void btnShowQueue_Click_1(object sender, EventArgs e)
        {
            dataGridViewQueue.Rows.Clear();
            var list = serviceQueue.DisplayQueue(); // استخدمي الكيو الصحيح

            foreach (var s in list)
            {
                dataGridViewQueue.Rows.Add(s.ID, s.Name, s.GPA, s.Faculty);
            }
        }

        private void btnServe_Click(object sender, EventArgs e)
        {
            Student servedStudent = serviceQueue.Dequeue(); // الطلاب اللي هيتخدموا من نفس الكيو

            if (servedStudent != null)
            {
                MessageBox.Show($"Student {servedStudent.Name} with GPA {servedStudent.GPA} is being served!");
                RefreshQueueGrid(); // تحديث عرض الكيو بعد ما الطالب اتخدم
            }
            else
            {
                MessageBox.Show("No students in queue.");
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            // get selected student ID from grid
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);

            // get student from linked list
            Student selectedStudent = students.ToList()
                                               .FirstOrDefault(st => st.ID == id);

            if (selectedStudent == null)
            {
                MessageBox.Show("Student not found.");
                return;
            }

            // open AddStudentForm with existing data
            AddStudentForm updateForm = new AddStudentForm(selectedStudent);

            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                bool updated = students.UpdateStudent(id, updateForm.CreatedStudent);

                if (updated)
                {
                    RefreshGrid();
                    MessageBox.Show("Student updated successfully.");
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            int id = Convert.ToInt32(
                dataGridView1.SelectedRows[0].Cells[1].Value); // ID column

            bool deleted = students.DeleteById(id);

            if (deleted)
            {
                RefreshGrid();
                MessageBox.Show("Student deleted successfully.");
            }
            else
            {
                MessageBox.Show("Student not found.");
            }
        }

        private void txtSearchId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

