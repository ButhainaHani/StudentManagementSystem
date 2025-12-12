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
        StudentLinkedList students = new StudentLinkedList();

        private void RefreshGrid()
        {
            dataGridView1.Rows.Clear();

            var list = students.ToList();
            foreach (var s in list)
            {
                dataGridView1.Rows.Add(s.Name, s.ID, s.Age, s.GPA, s.Faculty);
            }
        }
        // helper: convert linked list to list (if not already present in StudentLinkedList)
        private List<Student> GetAllStudents()
        {
            return students.ToList(); // students is your StudentLinkedList instance
        }

        // helper: show list of students in the DataGridView
        private void ShowStudentsInGrid(List<Student> list)
        {
            dataGridView1.Rows.Clear();

            foreach (var st in list)
            {
                dataGridView1.Rows.Add(st.Name, st.ID, st.Age, st.GPA, st.Faculty);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        
        {
            AddStudentForm addForm = new AddStudentForm();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                students.Add(addForm.CreatedStudent);

                RefreshGrid();  
            }
        }

        private List<Student> LinearSearchAllFields(string query)
        {
            var results = new List<Student>();

            if (string.IsNullOrWhiteSpace(query))
                return results;

            query = query.Trim();

            // get all students
            var list = GetAllStudents();

            foreach (var st in list)
            {
                bool match = false;

                // Name (case-insensitive)
                if (!string.IsNullOrEmpty(st.Name) &&
                    st.Name.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    match = true;
                }

                // ID (contains)
                if (!match && st.ID.ToString().Contains(query))
                    match = true;

                // Age (contains)
                if (!match && st.Age.ToString().Contains(query))
                    match = true;

                // GPA (contains)
                if (!match && st.GPA.ToString().Contains(query))
                    match = true;

                // Faculty (case-insensitive)
                if (!match && !string.IsNullOrEmpty(st.Faculty) &&
                    st.Faculty.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    match = true;
                }

                if (match)
                    results.Add(st);
            }

            return results;
        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // change txtSearch below if your textbox has a different name (e.g., txtSearchId)
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
    }
}
