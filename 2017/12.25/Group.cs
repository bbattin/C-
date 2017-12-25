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

        // полное копирование
        public static Group GetFullCopy(Group source)
        {
            Group grCopy = source;    // копирование полей value types
            // обработка reference types
            grCopy.students = (Student[])source.students.Clone();


            return grCopy;
        }

        // поиск средней оценки по каждому студенту
        public static int Average(Student s)
        {
            int x = 0;
            int sum = 0;
            int rezult = 0;

            for (int i = 0; i < s.assess.Length; i++)
            {
                x = s.assess[i];
                sum += x;
            }
            rezult = sum / s.assess.Length;
            return rezult;
        }

        

    }
}
