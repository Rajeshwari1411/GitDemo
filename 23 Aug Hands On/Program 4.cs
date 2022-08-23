using System;
using System.Runtime.InteropServices;

namespace Exercise4
{

    struct Employee
    {
        public int id;
        public string name;
        public int salary;
        public int deptno;

        public void getId(int id)
        {
            Console.WriteLine("Employee Id: " + id);
        }
        public void getname(string name)
        {
            Console.WriteLine("Employee name: " + name);
        }
        public void getsalary(int salary)
        {
            Console.WriteLine("Employee salary: " + salary);
        }
        public void getdeptno(int deptno)
        {
            Console.WriteLine(" Employee deptno: " + deptno); 
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

           
            Employee emp;

          
            emp.id = 1;

            emp.name = null;
            emp.salary = 1000;
            emp.deptno = 21;

          
            emp.getId(emp.id);
            emp.getname(emp.name);
            emp.getsalary(emp.salary);  
            emp.getdeptno(emp.deptno);


            Console.ReadLine();
        }
    }
}
