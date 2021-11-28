using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HK1_2020_2021_1.Controllers
{
    public class ThietBiController : Controller
    {
        // GET: ThietBiController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ThietBiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ThietBiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThietBiController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ThietBiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ThietBiController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ThietBiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ThietBiController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
