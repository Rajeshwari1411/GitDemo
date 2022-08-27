using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_aug_q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Students[] stu = { new Students(),
                       new Students(),
                       new Students() };

            
            stu[0].SetStudents(1, "Raj", 12);
            stu[1].SetStudents(2, "Raji", 21);
            stu[2].SetStudents(3, "Rajii", 22);

         
            stu[0].DisplayStudents();
            stu[1].DisplayStudents();
            stu[2].DisplayStudents();
            Console.ReadKey();
        }
    }
    
}
