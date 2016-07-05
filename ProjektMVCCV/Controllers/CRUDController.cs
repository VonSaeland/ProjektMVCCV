using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProjektMVCCV.Controllers
{
    public class CRUDController : Controller
    {
        ServiceReferenceItemCRUDCV.Service1Client ItemDB = new ServiceReferenceItemCRUDCV.Service1Client(); //referens till Item CRUD Servicen

        // GET: CRUDs
        public ActionResult GetAllItems()
        {
            return View(ItemDB.GetItemsList());
        }

        // GET: CRUDs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View(ItemDB.GetItemById(id));
        }

        // GET: CRUDs/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: CRUDs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string ItemName)
        {
            ItemDB.AddItem(ItemName);

            return View();
        }

        // GET: CRUDs/Edit/5
        public ActionResult Edit(string id)
        {
            return View(ItemDB.GetItemById(id));
        }
        // POST: CRUDs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string Id, string BookName)
        {
            ItemDB.UpdateItem(Id, BookName);
            return View(ItemDB.GetItemById(Id));
        }

        // GET: CRUDs/Delete/5
        public ActionResult Delete(string id)
        {
            return View(ItemDB.GetItemById(id));
        }
        // POST: CRUDs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ItemDB.DeleteItem(id);
            return RedirectToAction("Index");
        }
    }
}