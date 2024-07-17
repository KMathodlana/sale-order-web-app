using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesOrderWebApp.Models;

namespace SalesOrderWebApp.Controllers
{
    public class SaleOrderController : Controller
    {
        private readonly OrderContext _context;

        public SaleOrderController(OrderContext orderContext)
        {
            _context = orderContext;
        }

        // GET: SaleOrderController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SaleOrderController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SaleOrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SaleOrderController/Create
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

        // GET: SaleOrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SaleOrderController/Edit/5
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

        // GET: SaleOrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SaleOrderController/Delete/5
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
