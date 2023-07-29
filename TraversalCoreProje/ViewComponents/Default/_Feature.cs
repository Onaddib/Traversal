using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {

        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());


        public IViewComponentResult Invoke() {


          //  var values = featureManager.TGetList();
         // ViewBag.image1=featureManager.TGetByID
            return View(); 
        
        }
    }
}
