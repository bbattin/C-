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
    }
}
