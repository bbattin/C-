using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171224HW
{
    class UI
    {
        public static void PrintStudent(Student s)
        {
            Console.Write(Environment.NewLine + "Name: {0}, number: {1}, assessments: ", s.name, s.number);
            for (int i = 0; i < s.assess.Length; i++)
            {
                Console.Write("{0} ", s.assess[i]);
            }
            
        }

        public static void PrintGroup(Group p)
        {
            Console.WriteLine(Environment.NewLine + "Group name: {0}, specialty: {1}, students: ", p.name, p.spec);
            for (int i = 0; i < p.students.Length; i++)
            {
                PrintStudent(p.students[i]);
            }
        }
        public static void PrintAver(Student s, int aver)
        {
           Console.WriteLine();
           Console.Write(Environment.NewLine + "Average score on the student: {0} - {1}", s.name, aver);
        }

        public static void PrintAverGr(Group g, int aver)
        {
            Console.WriteLine();
            Console.Write(Environment.NewLine + "Average score for the group: {0} - {1}", g.name, aver);
        }

        public static void CaptionDelStInCopy()
        {
            Console.WriteLine();
            Console.WriteLine(Environment.NewLine + "Delete the last student in the copy of the group:");
        }

        public static void CaptiontAddStInMain()
        {
            Console.WriteLine();
            Console.WriteLine(Environment.NewLine + "Adding a student to the main group:");
        }
    }
}
