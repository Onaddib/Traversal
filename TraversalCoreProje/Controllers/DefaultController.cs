using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{

    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
