using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager =new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            var values = skillManager.GetList();
            return View(values);
        }
    }
}
