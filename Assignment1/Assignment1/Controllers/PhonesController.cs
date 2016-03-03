using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment1.Controllers
{

    public class PhonesController : Controller
    {
        // Collection of Phones
        private List<PhoneBase> Phones;


        // Default ctor
        public PhonesController()
        {
            // Initialize the collection
            Phones = new List<PhoneBase>();

            // Add to the collection using the original syntax
            var priv = new PhoneBase();
            priv.id = 1;
            priv.PhoneName = "Priv";
            priv.Manifacture = "Blackberry";
            priv.DateReleased = new DateTime(2015, 11, 6);
            priv.MSRP = 799;
            priv.ScreenSize = 5.43;
            Phones.Add(priv);

            // Add to the collection using the newer object initializer syntax
            //var galaxy = new PhoneBase
            //{
            //    id = 2;
            //    PhoneName = "Galaxy S6";
            //    Manifacture = "Samsung";
            //    DateReleased = new DateTime(2015, 4, 10);
            //    MSRP = 649;
            //    ScreenSrize = 5.1;
            //};
            //    Phones.Add(galaxy);

            var galaxy = new PhoneBase();
            galaxy.id = 2;
            galaxy.PhoneName = "Galaxy S6";
            galaxy.Manifacture = "Samsung";
            galaxy.DateReleased = new DateTime(2015, 4, 10);
            galaxy.MSRP = 649;
            galaxy.ScreenSize = 5.1;
            Phones.Add(galaxy);

            // Add toth e collection using object initializer syntax,
            // directly as the argument to the Phones.Add() method
            //Phones.Add(new PhoneBase
            //{
            //    id = 2;
            //PhoneName = "iPhone 6s";
            //Manifacture = "Apple";
            //DateReleased = new DateTime(2015, 9, 25);
            //MSRP = 649;
            //ScreenSize = 4.7;
            //});

            var iPhone = new PhoneBase();
            iPhone.id = 3;
            iPhone.PhoneName = "iPhone 6s";
            iPhone.Manifacture = "Apple";
            iPhone.DateReleased = new DateTime(2015, 9, 25);
            iPhone.MSRP = 649;
            iPhone.ScreenSize = 4.7;
            Phones.Add(iPhone);

        }

        // GET: Phones
        public ActionResult Index()
        {
            return View(Phones);
        }

        // GET: Phones/Details/5
        public ActionResult Details(int id)
        {
            return View(Phones[id-1]); 
        }

        // GET: Phones/Create
        public ActionResult Create()
        {
            return View(new PhoneBase());
        }

        // POST: Phones/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                var newItem = new PhoneBase();
                // Configure the unique identifier
                newItem.id = Phones.Count + 1;
                // Configure the string properties
                newItem.PhoneName = collection["PhoneName"];
                newItem.Manifacture = collection["Manifacture"];
                // Configure the date; it comes into the method as a string
                newItem.DateReleased = Convert.ToDateTime(collection["DateReleased"]);
                // Configure the numbers; they come into the method as strings
                int msrp;
                double ss;
                bool isNumber;

                //MSRP first//
                isNumber = Int32.TryParse(collection["MRSP"], out msrp);
                newItem.MSRP = msrp;

                // Next, the ScreenSize...
                isNumber = double.TryParse(collection["ScreenSize"], out ss);
                newItem.ScreenSize = ss;

                // Add to the collection
                Phones.Add(newItem);

                // Show the results, using the existing Details view

                //return RedirectToAction("Index");
                return View("Details", newItem);
            }
            catch
            {
                return View();
            }
        }

        //// GET: Phones/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Phones/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Phones/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: Phones/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
