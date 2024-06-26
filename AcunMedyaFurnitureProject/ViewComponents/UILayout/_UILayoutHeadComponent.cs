using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.ViewComponents.UILayout
{
    public class _UILayoutHeadComponent : ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View(); 
        }

    }
}
