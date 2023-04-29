using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Proje.ViewComponents.Contact
{
    public class SendMessageList:ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());


        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }

        //[HttpPost] /views/deafult/ içersine ekledim bole kabuletmedi
        //public IViewComponentResult Invoke(Message p)
        //{
        //    // messajın kayedeildi tarihi veritabanına yaz
        //    p.Date=Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    // baslangıcta ture okununca false çeviricez
        //    p.Status = true;
        //    messageManager.TAdd(p);
        //    return View();
        //}

    }
}
