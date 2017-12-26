using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171224HW
{
    struct Student
    {
        public string name;
        public int number;
        public int [] assess;

        public Student(string Name, int Num, int[] Assess)
        {
            this.name = Name;
            this.number = Num;
            this.assess = Assess;
        }
        
        // поиск средней оценки по конкретному студенту
        public static int Average(Student s)
        {
            int x = 0;
            int sum = 0;
            double rezult = 0;
            int rez = 0;

            for (int i = 0; i < s.assess.Length; i++)
            {
                x = s.assess[i];
                sum += x;
            }
            rezult = (double)sum / s.assess.Length;
            rez = Convert.ToInt32(Math.Round(rezult));
            return rez;
        }

    }
}
