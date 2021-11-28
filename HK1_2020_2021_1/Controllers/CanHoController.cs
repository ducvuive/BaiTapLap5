using HK1_2020_2021_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HK1_2020_2021_1.Controllers
{
    public class CanHoController : Controller
    {
        // GET: CanHoController
        public ActionResult Index()
        {
            return View();
        }

        public string ThemCH(CanHoModel ch)
        {
            int count;
            DataContext context = HttpContext.RequestServices.GetService(typeof(HK1_2020_2021_1.Models.DataContext)) as DataContext;
            count = context.ThemCanHo(ch);
            if (count == 1)
            {
                return "Mã căn hộ"+ch.MaCanHo + " Tên căn hộ: "+ch.TenCanHo;
            }
            else return " Thêm thất bại";
        }
        // GET: CanHoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CanHoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CanHoController/Create
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

        // GET: CanHoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CanHoController/Edit/5
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

        // GET: CanHoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CanHoController/Delete/5
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
