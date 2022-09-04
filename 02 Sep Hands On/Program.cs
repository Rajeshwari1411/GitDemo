using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using general_lib;


namespace oops_sept2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            product prod1 = new product();
            prod1.ProductId = 1;
            prod1.ProductName = "Coffee";
            prod1.QtySold = 2;
            prod1.UnitofMeasure = "Litres";
            prod1.UnitPrice = 100;
            prod1.QtyinHand = 5;
            prod1.ReorderLvl = 10;


            product prod2 = new product();
            prod2.ProductId = 2;
            prod2.ProductName = "Tea";
            prod2.QtySold = 1;
            prod2.UnitofMeasure = "litres";
            prod2.UnitPrice = 100;
            prod2.QtyinHand = 3;
            prod2.ReorderLvl = 7;

            product prod3 = new product();
            prod3.Addproduct();

            List<product> prodlist = new List<product>();
            prodlist.Add(prod1);
            prodlist.Add(prod2);
            prodlist.Add(prod3);

            Console.WriteLine("One category many products ");



            Category cat = new Category();
            cat.CatId = 1;
            cat.CatName = "BEVERAGES";
            cat.Description = "Different types of drinks availble ";
            cat.ProductList = prodlist;


            Console.WriteLine("===========================");
            Console.WriteLine("Category Details");
            Console.WriteLine("this Category is " + cat.CatName);
            Console.WriteLine("Category ID" + cat.CatId);
            Console.WriteLine("A short description of this category\t " + cat.Description);

            foreach (var item in cat.ProductList)
            {
                Console.WriteLine(item.ProductId);
                Console.WriteLine(item.ProductName);
                Console.WriteLine(item.QtySold);
                Console.WriteLine(item.UnitPrice);
                Console.WriteLine(item.UnitofMeasure);
                Console.WriteLine(item.QtyinHand);
                Console.WriteLine(item.ReorderLvl);
            }





            Console.ReadKey();

        }
    }
}
