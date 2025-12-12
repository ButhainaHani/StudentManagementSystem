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

        private void btnAdd_Click(object sender, EventArgs e)
        
        {
            AddStudentForm addForm = new AddStudentForm();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                students.Add(addForm.CreatedStudent);

                RefreshGrid();  
            }
        }

        private int BinarySearchById(List<Student> arr, int id)
        {
            int left = 0;
            int right = arr.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid].ID == id)
                    return mid;

                if (arr[mid].ID < id)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1; // not found
        }



        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearchId.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Please enter a search value.");
                return;
            }

            // Get all students from the linked list into a List (array-like structure)
            var list = students.ToList();

            if (list.Count == 0)
            {
                MessageBox.Show("No students in the system.");
                return;
            }

            // Linear search over all fields
            var results = list.Where(std =>
                (!string.IsNullOrEmpty(std.Name) && std.Name.ToLower().Contains(query)) ||
                std.ID.ToString().Contains(query) ||
                std.Age.ToString().Contains(query) ||
                std.GPA.ToString().Contains(query) ||
                (!string.IsNullOrEmpty(std.Faculty) && std.Faculty.ToLower().Contains(query))
            ).ToList();

            if (results.Count == 0)
            {
                MessageBox.Show("No results found.");
                return;
            }

            // Show only matched students in DataGridView
            dataGridView1.Rows.Clear();
            foreach (var std in results)
            {
                dataGridView1.Rows.Add(std.Name, std.ID, std.Age, std.GPA, std.Faculty);
            }
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
