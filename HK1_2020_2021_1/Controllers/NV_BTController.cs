using HK1_2020_2021_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HK1_2020_2021_1.Controllers
{
    public class NV_BTController : Controller
    {
        // GET: NV_BT
        public ActionResult Index(string MaNV)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(HK1_2020_2021_1.Models.DataContext)) as DataContext;
            return View(context.LietKeThietBi(MaNV));
            /*return Content(MaNV);*/
        }

        // GET: NV_BT/Details/5
        public ActionResult Details(NV_BT bt)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(HK1_2020_2021_1.Models.DataContext)) as DataContext;
            return View(context.Lay_NV_BT(bt));
        }

        // GET: NV_BT/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NV_BT/Create
      /*  [HttpPost]
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
        }*/

        // GET: NV_BT/Edit/5
       /* public ActionResult Edit(int id)
        {
            return View();
        }*/

        // POST: NV_BT/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(NV_BT bt)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(HK1_2020_2021_1.Models.DataContext)) as DataContext;
            context.CapNhap_NV_BT(bt);
            return Redirect("/NhanVien/LayTenNV");
        }

        // GET: NV_BT/Delete/5
/*        public ActionResult Delete(int id)
        {
            return View();
        }*/

        // POST: NV_BT/Delete/5
        public ActionResult Delete(NV_BT bt)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(HK1_2020_2021_1.Models.DataContext)) as DataContext;
            if (context.xoaBaoTri(bt) != 0)
            {
                return Redirect("/Home/Index");
            }
            /*return View(context.LietKeThietBi(bt.MaNhanVien));*/
            return Redirect("/Home/Index");
        }
    }
}
