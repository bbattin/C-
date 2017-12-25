using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171224HW
{
    struct Group
    {
        public string name;
        public string spec;
        public Student[] students;  // reference type

        public Group(string Name, string Spec, Student [] Students)
        {
            this.name = Name;
            this.spec = Spec;
            this.students = Students;
        }

        public static void Add(ref Group gr, Student newStudent)
        {
            Array.Resize(ref gr.students, gr.students.Length + 1);
            gr.students[gr.students.Length - 1] = newStudent;
        }

        public static void Delete(ref Group gr)
        {
            Array.Resize(ref gr.students, gr.students.Length - 1);
        }

        public static Group GetFullCopy(Group source)
        {
            Group grCopy = source;    // копирование полей value types
            // обработка reference types
            grCopy.students = (Student[])source.students.Clone();


            return grCopy;
        }
    }
}
