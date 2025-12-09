using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    //internal class StudentLinkedList
    //{
    //}
    using System.Collections.Generic;

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

        // رجّع كل الطلاب في List (عشان نعرضهم في الجريد)
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
    }

}
