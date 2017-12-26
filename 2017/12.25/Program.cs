using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// создание структур для группы студентов с оценками

namespace _20171224HW
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student stud1 = new Student("Jane Dou", 14, new int[] { 5, 2, 3, 5 });
            Student stud2 = new Student("Catherine Smith", 17, new int[] { 5, 3, 3, 2, 4, 3 });
            Student stud3 = new Student("Lana Lee", 45, new int[] { 3, 2, 2, 2, 3 });
            Student stud4 = new Student("Mike Shane", 8, new int[] { 3, 4, 3, 5, 4, 3 });

            Group group = new Group("M3", "Managment", new Student[] { stud1, stud2, stud3, stud4});

            //UI.Print(stud1);

            UI.PrintGroup(group);

            //Group groupCopy = group;    // Копировани "по полям"
            Group groupCopy = Group.GetFullCopy(group);    // Копировани полное

            groupCopy.name = "M3-copy";

            Group.Delete(ref groupCopy);
            UI.CaptionDelStInCopy();
            UI.PrintGroup(groupCopy);

            Student stud5 = new Student("Bill Nork", 78, new int[] { 2, 4, 5, 5, 3 });

            Group.Add(ref group, stud5);
            UI.CaptiontAddStInMain();
            UI.PrintGroup(group);

            int aver1 = Student.Average(stud1);
            int aver2 = Student.Average(stud2);
            int aver3 = Student.Average(stud3);
            int aver4 = Student.Average(stud4);
            int aver5 = Student.Average(stud5);

            int averGr = Group.AverageGroup(group);

            UI.PrintAver(stud1, aver1);
            UI.PrintAver(stud2, aver2);
            UI.PrintAver(stud3, aver3);
            UI.PrintAver(stud4, aver4);
            UI.PrintAver(stud5, aver5);

            UI.PrintAverGr(group, averGr);

            int averGrCopy = Group.AverageGroup(groupCopy);
            UI.PrintAverGr(groupCopy, averGrCopy);

            Console.ReadKey();
        }
    }
}
