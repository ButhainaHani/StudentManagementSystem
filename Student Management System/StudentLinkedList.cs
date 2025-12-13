using System;
using System.Collections.Generic;

namespace Student_Management_System
{
    public class Node
    {
        public Student Data;
        public Node Next;

        public Node(Student data)
        {
            Data = data;
            Next = null;
        }
    }

    public class StudentLinkedList
    {
        public Node head;

        // Add at end
        public void Add(Student s)
        {
            Node newNode = new Node(s);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = newNode;
        }

        // Convert to List
        public List<Student> ToList()
        {
            List<Student> list = new List<Student>();
            Node temp = head;

            while (temp != null)
            {
                list.Add(temp.Data);
                temp = temp.Next;
            }

            return list;
        }

        // Search by ID
        public Student SearchById(int id)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.Data.ID == id)
                    return temp.Data;
                temp = temp.Next;
            }
            return null;
        }


        // ================================
        //       SORT FUNCTIONS
        // ================================

        private void Swap(Node a, Node b)
        {
            Student temp = a.Data;
            a.Data = b.Data;
            b.Data = temp;
        }

        // Sort by Name (A-Z)
        public void SortByName()
        {
            if (head == null) return;

            Node current = head;
            while (current != null)
            {
                Node index = current.Next;
                while (index != null)
                {
                    if (string.Compare(current.Data.Name, index.Data.Name) > 0)
                    {
                        Swap(current, index);
                    }
                    index = index.Next;
                }
                current = current.Next;
            }
        }

        // Sort by GPA (High → Low)
        public void SortByGPA()
        {
            if (head == null) return;

            Node current = head;
            while (current != null)
            {
                Node index = current.Next;
                while (index != null)
                {
                    if (current.Data.GPA < index.Data.GPA)
                    {
                        Swap(current, index);
                    }
                    index = index.Next;
                }
                current = current.Next;
            }
        }

        // Sort by ID (small → big)
        public void SortByID()
        {
            if (head == null) return;

            Node current = head;
            while (current != null)
            {
                Node index = current.Next;
                while (index != null)
                {
                    if (current.Data.ID > index.Data.ID)
                    {
                        Swap(current, index);
                    }
                    index = index.Next;
                }
                current = current.Next;
            }
        }

        // لو عندك Age في Student Class
        public void SortByAge()
        {
            if (head == null) return;

            Node current = head;
            while (current != null)
            {
                Node index = current.Next;
                while (index != null)
                {
                    if (current.Data.Age > index.Data.Age)
                    {
                        Swap(current, index);
                    }
                    index = index.Next;
                }
                current = current.Next;
            }
        }
        public bool DeleteById(int id)
        {
            if (head == null)
                return false;

            // If head is the one to delete
            if (head.Data.ID == id)
            {
                head = head.Next;
                return true;
            }

            Node prev = head;
            Node curr = head.Next;

            while (curr != null)
            {
                if (curr.Data.ID == id)
                {
                    prev.Next = curr.Next;
                    return true;
                }

                prev = curr;
                curr = curr.Next;
            }

            return false;
        }
        public bool UpdateStudent(int id, Student newData)
        {
            Node temp = head;

            while (temp != null)
            {
                if (temp.Data.ID == id)
                {
                    temp.Data.Name = newData.Name;
                    temp.Data.ID = newData.ID;
                    temp.Data.Age = newData.Age;
                    temp.Data.GPA = newData.GPA;
                    temp.Data.Faculty = newData.Faculty;
                    return true;
                }
                temp = temp.Next;
            }

            return false;
        }

        // إضافة جوه class StudentLinkedList بعد دوال Sort
        // ===================================================

        // حذف طالب بالـ ID
        public void RemoveByID(int id)
        {
            if (head == null) return;

            if (head.Data.ID == id)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Data.ID == id)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }

        // تحديث بيانات طالب بالـ ID
        public void UpdateStudent(Student updatedStudent)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data.ID == updatedStudent.ID)
                {
                    current.Data.Name = updatedStudent.Name;
                    current.Data.Age = updatedStudent.Age;
                    current.Data.GPA = updatedStudent.GPA;
                    current.Data.Faculty = updatedStudent.Faculty;
                    return;
                }
                current = current.Next;
            }
        }

    }
}