﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModule
{
    public class Class1
    {
     public class HomeController : Controller

    {

        //

        // GET: /Home/ 

        public ActionResult Index()

        {

            return View();

        } 

        //

        // GET: /Home/Details/5 

        public ActionResult Details(int id)

        {

            return View();

        } 

        //

        // GET: /Home/Create 

        public ActionResult Create()

        {

            return View();

        }  

        //

        // POST: /Home/Create 

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Create(FormCollection collection)

        {

            try

            {

                // TODO: Add insert logic here 

                return RedirectToAction("Index");

            }

            catch

            {

                return View();

            }

        } 

        //

        // GET: /Home/Edit/5

        public ActionResult Edit(int id)

        {

            return View();

        } 

        //

        // POST: /Home/Edit/5 

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Edit(int id, FormCollection collection)

        {

            try

            {

                // TODO: Add update logic here

                return RedirectToAction("Index");

            }

            catch

            {

                return View();

            }

        }

    }

}

