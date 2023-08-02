using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Comment
{
    public class _AddComments : ViewComponent

    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
