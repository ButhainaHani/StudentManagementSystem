using System;
using System.Collections.Generic;

namespace Student_Management_System
{
    public class StudentPriorityQueue
    {
        private List<Student> queue;

        public StudentPriorityQueue()
        {
            queue = new List<Student>();
        }

        // إضافة طالب وترتيب القائمة حسب GPA
        public void Enqueue(Student s)
        {
            queue.Add(s);
            queue.Sort((a, b) => b.GPA.CompareTo(a.GPA)); // ترتيب من الأعلى للأقل
        }

        // إزالة الطالب ذو الأولوية الأعلى
        public Student Dequeue()
        {
            if (queue.Count == 0) return null;
            Student s = queue[0];
            queue.RemoveAt(0);
            return s;
        }

        // عرض كل الطلاب في الكيو
        public List<Student> DisplayQueue()
        {
            return new List<Student>(queue);
        }

        // حذف طالب حسب ID
        public void RemoveByID(int id)
        {
            queue.RemoveAll(s => s.ID == id);
        }

        // تعديل بيانات طالب
        public void UpdateStudent(Student updatedStudent)
        {
            for (int i = 0; i < queue.Count; i++)
            {
                if (queue[i].ID == updatedStudent.ID)
                    queue[i] = updatedStudent;
            }
            queue.Sort((a, b) => b.GPA.CompareTo(a.GPA)); // ترتيب حسب GPA بعد التحديث
        }

    }
}

