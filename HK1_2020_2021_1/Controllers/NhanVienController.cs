using HK1_2020_2021_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

namespace HK1_2020_2021_1.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: NhanVienController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SoLanSua()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ListByTime(int solan)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(HK1_2020_2021_1.Models.DataContext)) as DataContext;
            return View(context.LayNhanVien(solan));
        }
        // GET: NhanVienController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult LayTenNV()
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(HK1_2020_2021_1.Models.DataContext)) as DataContext;
            return View(context.LayTenNV());
        }
        // GET: NhanVienController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhanVienController/Create
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

        // GET: NhanVienController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NhanVienController/Edit/5
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

        // GET: NhanVienController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NhanVienController/Delete/5
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
