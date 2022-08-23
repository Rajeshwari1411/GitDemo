using System;


public struct Employee
{
    public int No;

    public string Name;

    public int Sal;

    public int Deptno;

    public void SetEmployee(int no, string name, int sal,int deptno)

    {

        No = no;

        Name = name;

        Sal = sal;

        Deptno = deptno;    

    }




    public void DisplayEmployee()

    {

        Console.WriteLine("Employee:");

        Console.WriteLine("\tNo    : " + No);

        Console.WriteLine("\tName   : " + Name);

        Console.WriteLine("\tSal   : " + Sal);

        Console.WriteLine("\tDeptno   : " + Deptno);

        Console.WriteLine("\n");

    }
}


class Program
{

   

    static void Main(string[] args)
    {



   

        Employee[] emp = { new Employee(),

                       new Employee(),

                       new Employee(),
                       
                       new Employee(),
        };



        

        emp[0].SetEmployee(1, "Raji", 2000,20);

        emp[1].SetEmployee(2, "Venkatt", 2100,21);

        emp[2].SetEmployee(3, "Jaya", 2200,22);

        emp[3].SetEmployee(4, "Raj", 2300, 23);



        emp[0].DisplayEmployee();

        emp[1].DisplayEmployee();

        emp[2].DisplayEmployee();

        emp[3].DisplayEmployee();
    }
}
