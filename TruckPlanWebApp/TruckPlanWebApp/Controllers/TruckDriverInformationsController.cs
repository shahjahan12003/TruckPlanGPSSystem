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
    public class TruckDriverInformationsController : Controller
    {
        private TruckPlanContext db = new TruckPlanContext();

        // GET: TruckDriverInformations
        public async Task<ActionResult> Index()
        {
            return View(await db.TruckDriverInformations.ToListAsync());
        }

        // GET: TruckDriverInformations/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TruckDriverInformation truckDriverInformation = await db.TruckDriverInformations.FindAsync(id);
            if (truckDriverInformation == null)
            {
                return HttpNotFound();
            }
            return View(truckDriverInformation);
        }

        // GET: TruckDriverInformations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TruckDriverInformations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,GPSDeviceID,DriverName,DriverLicenseNo,DriverNationalIDNo,BirthDate")] TruckDriverInformation truckDriverInformation)
        {
            if (ModelState.IsValid)
            {
                db.TruckDriverInformations.Add(truckDriverInformation);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(truckDriverInformation);
        }

        // GET: TruckDriverInformations/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TruckDriverInformation truckDriverInformation = await db.TruckDriverInformations.FindAsync(id);
            if (truckDriverInformation == null)
            {
                return HttpNotFound();
            }
            return View(truckDriverInformation);
        }

        // POST: TruckDriverInformations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,GPSDeviceID,DriverName,DriverLicenseNo,DriverNationalIDNo,BirthDate")] TruckDriverInformation truckDriverInformation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(truckDriverInformation).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(truckDriverInformation);
        }

        // GET: TruckDriverInformations/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TruckDriverInformation truckDriverInformation = await db.TruckDriverInformations.FindAsync(id);
            if (truckDriverInformation == null)
            {
                return HttpNotFound();
            }
            return View(truckDriverInformation);
        }

        // POST: TruckDriverInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            TruckDriverInformation truckDriverInformation = await db.TruckDriverInformations.FindAsync(id);
            db.TruckDriverInformations.Remove(truckDriverInformation);
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
