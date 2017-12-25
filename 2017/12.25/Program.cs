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
            Student stud2 = new Student("Catherine Smith", 17, new int[] { 5, 5, 3, 4, 4, 3 });
            Student stud3 = new Student("Lana Lee", 45, new int[] { 3, 4, 4, 4, 3 });
            Student stud4 = new Student("Mike Shane", 8, new int[] { 5, 4, 4, 5, 4, 3 });

            Group group = new Group("M3", "Managment", new Student[] { stud1, stud2, stud3, stud4});

            //UI.Print(stud1);

            UI.Print2(group);

            //Group groupCopy = group;    // Копировани "по полям"
            Group groupCopy = Group.GetFullCopy(group);    // Копировани полное

            UI.Print2(groupCopy);

            Console.ReadKey();
        }
    }
}
