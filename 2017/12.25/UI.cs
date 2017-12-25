using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171224HW
{
    class UI
    {
        public static void Print(Student s)
        {
            Console.Write(Environment.NewLine + "Name: {0}, number: {1}, assessments: ", s.name, s.number);
            for (int i = 0; i < s.assess.Length; i++)
            {
                Console.Write("{0} ", s.assess[i]);
            }
            
        }

        public static void Print2(Group p)
        {
            Console.Write(Environment.NewLine + "Group name: {0}, cpec: {1}, students: ", p.name, p.spec);
            for (int i = 0; i < p.students.Length; i++)
            {
                Print(p.students[i]);
            }
        }

        
    }
}
