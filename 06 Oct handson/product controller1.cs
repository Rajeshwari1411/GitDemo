using modelbinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modelbinding.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        static List<ProductModel> prodList = new List<ProductModel>();
        static ProductController()
        {
            prodList.Add(new ProductModel { Prodid = 1, Prodname = "book", ManufacturingDate = new DateTime(2021, 03, 06) });
            prodList.Add(new ProductModel { Prodid = 2, Prodname = "pen", ManufacturingDate = new DateTime(2022, 04, 07) });
            prodList.Add(new ProductModel { Prodid = 3, Prodname = "pencil", ManufacturingDate = new DateTime(2020, 05, 09) });


        }
        public ActionResult Index()    //start page
        {
            return View(prodList);
        }
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductModel model)
        {
            prodList.Add(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            ProductModel foundData = prodList.Find(customer => customer.Prodid == id);
            return View(foundData);
        }

        public ActionResult Edit(int id)
        {
            ProductModel foundData = prodList.Find(customer => customer.Prodid == id);


            return View(foundData);
        }

        [HttpPost]

        public ActionResult Edit(int id, ProductModel m)
        {
            ProductModel foundData = prodList.Find(customer => customer.Prodid == id);
            prodList.Remove(foundData);
            prodList.Add(m);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            ProductModel foundData = prodList.Find(customer => customer.Prodid == id);
            return View(foundData);
        }

        [HttpPost]
        public ActionResult Delete(int id, ProductModel cust)
        {
            ProductModel foundData = prodList.Find(customer => customer.Prodid == id);
            prodList.Remove(foundData);
            return View(foundData);
        }


    }
}
