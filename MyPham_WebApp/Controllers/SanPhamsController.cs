using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPham_WebApp.Controllers
{
    public class SanPhamsController : Controller
    {
        // GET: SanPhams
        public ActionResult Index()
        {
            return View();
        }

        // GET: SanPhams/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SanPhams/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SanPhams/Create
        [HttpPost]
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

        // GET: SanPhams/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SanPhams/Edit/5
        [HttpPost]
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

        // GET: SanPhams/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SanPhams/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
