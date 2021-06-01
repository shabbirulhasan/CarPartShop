namespace SkodaShop.Web.Controllers
{
    using SkodaShop.Data.Common.Repository;
    using SkodaShop.Data.Models;
    using System.Web.Mvc;
    using System.Linq;

    public class OrderController : Controller
    {
        // todo change part with orders
        private IRepository<Order> orders;

        public OrderController(IRepository<Order> orders)
        {
            this.orders = orders;
        }

        public ActionResult Index()
        {
            var orders = this.orders.All();

            return this.View(orders);
        }
    }
}