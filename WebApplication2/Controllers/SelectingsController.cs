using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class SelectingsController : Controller
    {
        public myDataBaseEntities db;

        public SelectingsController()
        {
            db = new myDataBaseEntities();
        }

        protected override void Dispose(bool disposing)
        {
            if (db != null)
            {
                db.Dispose();
            }
        }
        
        public void SetViewData(int? selectId = null)
        {
            ViewData["Status"] = RadioButtonList.Create(db.Selecting.ToList(), "SelectId", "Name", selectId);
        }

        [HttpGet()]
        public ActionResult Index()
        {
            var id = (db.Selecting.Where(c => c.Status == true).FirstOrDefault().SelectId);
            ViewData["Status"] = RadioButtonList.Create(db.Selecting.ToList(), "SelectId", "Name", id);
            return View(db.Selecting.OrderBy(c => c.SelectId).ToArray());
        }

        [HttpPost()]
        public ActionResult Index(int? Status)
        {
            int updateCount = db.Database.ExecuteSqlCommand("UPDATE Selecting SET Status=0", Status.Value);
            Selecting sel = db.Selecting.FirstOrDefault(c => c.SelectId == Status.Value);
            sel.Status = true;
            db.SaveChanges();
            SetViewData(db.Selecting.Where(c => c.Status == true).FirstOrDefault().SelectId);
            return View(db.Selecting.OrderBy(c => c.SelectId).ToArray());
        }


        [HttpGet()]
        public async Task<ActionResult> Edit(int? id = 1)
        {
            Options model = await db.Options.FindAsync(id.Value);
            ViewData["Status"] = RadioButtonList.Create(db.Selecting.ToList(), "SelectId", "Name", model.SelectId);
            return View(model);
        }

        [HttpPost()]
        public async Task<ActionResult> Edit(Options option)
        {
            db.Entry(option).State = System.Data.Entity.EntityState.Modified;
            await db.SaveChangesAsync();
            ViewData["Status"] = RadioButtonList.Create(db.Selecting.ToList(), "SelectId", "Name", option.SelectId);
            return RedirectToAction("Edit", new { id = option.OptionId });
        }
    }
}