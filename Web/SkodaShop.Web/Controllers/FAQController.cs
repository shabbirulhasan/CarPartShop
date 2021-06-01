namespace SkodaShop.Web.Controllers
{
    using System.Web.Mvc;

    public class FAQController : Controller
    {
        // GET: FAQ
        public ActionResult Question()
        {
            return this.View();
        }
    }
}