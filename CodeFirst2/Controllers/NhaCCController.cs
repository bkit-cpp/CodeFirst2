using CodeFirst2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;
namespace CodeFirst2.Controllers
{
    public class NhaCCController : Controller
    {
        // GET: NhaCC
        private EFCodeFirst2 efcf = new EFCodeFirst2();
        public ActionResult Index()
        {
            return View(efcf.nhaccs.ToList());
        }
        public ActionResult Details(int ?id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCC nc = efcf.nhaccs.Find(id);
            if(nc==null)
            {
                return HttpNotFound();
            }
            return View(nc);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind(Include = "IDNCC,TenNCC,TenGiaoDich,SDT,fax,Email")] NhaCC nc)
        {
            if(ModelState.IsValid)
            {
                efcf.nhaccs.Add(nc);
                efcf.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nc);
        }
        public ActionResult Edit(int ?id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCC nc = efcf.nhaccs.Find(id);
            if(nc==null)
            {
                return HttpNotFound();
            }
            return View(nc);
        }
        [HttpPost]
        public ActionResult Edit([Bind(Include = "IDNCC,TenNCC,TenGiaoDich,SDT,fax,Email")]NhaCC nc)
        {
            if(ModelState.IsValid)
            {
                efcf.Entry(nc).State = EntityState.Modified;
                efcf.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nc);
        }
        public ActionResult Delete(int ?id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCC nc = efcf.nhaccs.Find(id);
            if (nc == null)
            {
                return HttpNotFound();
            }
            return View(nc);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            NhaCC nc = efcf.nhaccs.Find(id);
            efcf.nhaccs.Remove(nc);
            efcf.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}