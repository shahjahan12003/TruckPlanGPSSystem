using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TruckPlanWebApp.DAL;
using TruckPlanWebApp.Models;

namespace TruckPlanWebApp.Controllers
{
    public class TruckInformationsController : Controller
    {
        private TruckPlanContext db = new TruckPlanContext();

        // GET: TruckInformations
        public async Task<ActionResult> Index()
        {
            return View(await db.TruckInformations.ToListAsync());
        }

        // GET: TruckInformations/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TruckInformation truckInformation = await db.TruckInformations.FindAsync(id);
            if (truckInformation == null)
            {
                return HttpNotFound();
            }
            return View(truckInformation);
        }

        // GET: TruckInformations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TruckInformations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,GPSDeviceID,EngineNo,ChesisNo,ModelNo,TruckLicenseNo")] TruckInformation truckInformation)
        {
            if (ModelState.IsValid)
            {
                db.TruckInformations.Add(truckInformation);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(truckInformation);
        }

        // GET: TruckInformations/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TruckInformation truckInformation = await db.TruckInformations.FindAsync(id);
            if (truckInformation == null)
            {
                return HttpNotFound();
            }
            return View(truckInformation);
        }

        // POST: TruckInformations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,GPSDeviceID,EngineNo,ChesisNo,ModelNo,TruckLicenseNo")] TruckInformation truckInformation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(truckInformation).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(truckInformation);
        }

        // GET: TruckInformations/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TruckInformation truckInformation = await db.TruckInformations.FindAsync(id);
            if (truckInformation == null)
            {
                return HttpNotFound();
            }
            return View(truckInformation);
        }

        // POST: TruckInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            TruckInformation truckInformation = await db.TruckInformations.FindAsync(id);
            db.TruckInformations.Remove(truckInformation);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
