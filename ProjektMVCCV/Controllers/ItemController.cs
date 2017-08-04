using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProjektMVCCV.Controllers
{
    public class ItemController : Controller
    {
        ServiceReferenceItemCRUDCV.Service1Client ItemDB = new ServiceReferenceItemCRUDCV.Service1Client(); //referens till Item CRUD Servicen

        // GET: Item
        public ActionResult GetAllItems()
        {
            return View(ItemDB.GetItemsList());
        }

        // GET: Item/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View(ItemDB.GetItemById(id));
        }

        // GET: Item/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Item/Create
        [HttpPost]
        public ActionResult Create(string ItemName)
        {
            try
            {
                ItemDB.AddItem(ItemName);

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Item/Edit/5
        public ActionResult Edit(string id)
        {
            return View(ItemDB.GetItemById(id));
        }

        // POST: Item/Edit/5
        [HttpPost]
        public ActionResult Edit(string Id, string ItemName)
        {
            try
            {
                ItemDB.UpdateItem(Id, ItemName);
                return View(ItemDB.GetItemById(Id));
            }
            catch
            {
                return View();
            }
        }

        // GET: Item/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Item/Delete/5
        [HttpPost]
        public ActionResult Delete(string id)
        {
            try
            {
                // TODO: Add delete logic here
                ItemDB.DeleteItem(id);

                return View(ItemDB.GetItemById(id));
            }
            catch
            {
                return View();
            }
        }
    }
}
