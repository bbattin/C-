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

        // добавление студентов
        public Group(string Name, string Spec, Student [] Students)
        {
            this.name = Name;
            this.spec = Spec;
            this.students = Students;
        }

        // добавление студента
        public static void Add(ref Group gr, Student newStudent)
        {
            Array.Resize(ref gr.students, gr.students.Length + 1);
            gr.students[gr.students.Length - 1] = newStudent;
        }

        // удаление последнего студента
        public static void Delete(ref Group gr)
        {
            Array.Resize(ref gr.students, gr.students.Length - 1);
        }

        // полное копирование
        public static Group GetFullCopy(Group source)
        {
            Group grCopy = source;                                  // копирование полей value types
            grCopy.students = (Student[])source.students.Clone();   // обработка reference types
            return grCopy;
        }

        // поиск средней оценки по всей группе
        public static int AverageGroup(Group g)
        {
            int x = 0;
            int sum = 0;
            double rezult = 0;
            int rez = 0;

            for (int i = 0; i < g.students.Length; i++)
            {
                x = Student.Average(g.students[i]);
                sum += x;
            }
            rezult = (double)sum / g.students.Length;
            rez = Convert.ToInt32(Math.Round(rezult));
            return rez;
        }

    }
}
