using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Portfolio
{
    public class PortfolioList:ViewComponent
    {
        PortfolioManager PortfolioManager=new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = PortfolioManager.GetList();
            return View(values);
        }
    }
}
