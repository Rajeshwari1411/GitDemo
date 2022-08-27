using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_aug_q1
{
    internal class Exercise
    {
        public struct Students
        {
            public int Id;
            public string Name; 


            public void SetStudents(int id,string name)
            {
                this.Id = id;
                this.Name = name;
            }

            public void DisplayStudents()
            {
                Console.WriteLine("Students:");
                Console.WriteLine("\tId :" + Id);
                Console.WriteLine("\tname :" + Name);
                Console.WriteLine("\n");
            }
        }

        class Program1
        {
            static void Main(string[] args)
            {
                Students[] stu = { new Students(), new Students(), new Students(), new Students() };
                stu[0].SetStudents(1, "Raj");
                stu[1].SetStudents(2, "Raji");
                stu[2].SetStudents(3, "Rajii");

                stu[0].DisplayStudents();
                stu[1].DisplayStudents();
                stu[2].DisplayStudents();

            }
        }
           
    }
}
