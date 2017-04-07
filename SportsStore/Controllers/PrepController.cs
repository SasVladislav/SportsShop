using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace SportsStore.Controllers
{
    public class PrepController : Controller
    {
        IRepository repository;
        public PrepController()
        {
            repository = new ProductRepository();
        }
        // GET: Prep
        public ActionResult Index()
        {
            return View(repository.Products);
        }
        public async Task<ActionResult> DeleteProduct(int id)
        {
            await repository.DeleteProductAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> SaveProduct(Product product)
        {
            await repository.SaveProductAsync(product);
            return RedirectToAction("Index");
        }

        public ActionResult Orders()
        {
            return View(repository.Orders);
        }

        public async Task<ActionResult> DeleteOrder(int order)
        {
            await repository.DeleteOrderAsync(order);
            return RedirectToAction("Oders");
        }

        public async Task<ActionResult> SaveOrder(Order order)
        {
            await repository.SaveOrderAsync(order);
            return RedirectToAction("Orders");
        }
            }
}