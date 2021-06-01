namespace SkodaShop.Web.Controllers
{
    using System.Web.Mvc;
    using SkodaShop.Data.Common.Repository;
    using SkodaShop.Data.Models;    

    public class HomeController : Controller
    {
        private IRepository<Part> parts;
      
        public HomeController(IRepository<Part> parts)
        {
            this.parts = parts;
        }

        public ActionResult Index()
        {
            var parts = this.parts.All();

            return this.View(parts);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return this.View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return this.View();
        }
    }
}