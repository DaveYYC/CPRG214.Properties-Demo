using CPRG214.Properties.BLL;
using CPRG214.Properties.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CPRG214.Properties.Presentation.Controllers
{
    public class OwnerController : Controller
    {
        // GET: Owner
        public ActionResult Index()
        {
            var owners = OwnerManager.GetAll();
            return View(owners);
        }

        // GET: Owner/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Owner/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Owner owner)
        {
            try
            {
                //call the OwnerManager to add
                OwnerManager.Add(owner);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Owner/Edit/5
        public ActionResult Edit(int id)
        {
            var owner = OwnerManager.Find(id);
            return View(owner);
        }

        // POST: Owner/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Owner owner)
        {
            try
            {
                //call the OwnerManager to add
                OwnerManager.update(owner);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}