using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Part2Poe.Models;

//this is the product controller where the user will be able to create, edit, view and delete items in the list
namespace Part2Poe.Controllers
{

    //the project was taken and adabted by The Amazing Codeverse youtube channel
    //link to video : https://youtu.be/6AP7SmIIJIE
    [Authorize]
    public class ProductsController : Controller
    {
        private Task2ProgEntities db = new Task2ProgEntities();

        // GET: Products
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Farmer);
            return View(products.ToList());
        }
         //is code was taken and adabted from Harith Computers & Technology youtube channel*@
    //re is the link: https://www.youtube.com/watch?v=gCRukwJ22-I&ab_channel=HarithaComputers%26Technology*@
    //is snip of code was to create the search bar in the products page*@
       // public ActionResult Index(string search)
       // {
           //List<Product>listtemp = db.Products.ToList();
           // return View(db.Products.Where(x=>x.ProductDate.StartsWith(search) || search==null).ToList());
        //}

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.FarmerId = new SelectList(db.Farmers, "FarmerId", "FarmerName");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductId,ProductName,ProductDescription,ProductQuantity,ProductPrice,ProductDate,FarmerId")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FarmerId = new SelectList(db.Farmers, "FarmerId", "FarmerName", product.FarmerId);
            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.FarmerId = new SelectList(db.Farmers, "FarmerId", "FarmerName", product.FarmerId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductId,ProductName,ProductDescription,ProductQuantity,ProductPrice,ProductDate,FarmerId")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FarmerId = new SelectList(db.Farmers, "FarmerId", "FarmerName", product.FarmerId);
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
