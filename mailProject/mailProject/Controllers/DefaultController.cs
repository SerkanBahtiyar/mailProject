using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;
using System.ComponentModel.DataAnnotations;
using mailProject.Models;

namespace mailProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public PartialViewResult Iletisim()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult Iletisim(Email model)
        {

            
            
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("serkanbahtiyar701@gmail.com", "wfhmpjjwtksapadm"),
                EnableSsl = true,
            };
            MailMessage mailim = new MailMessage();
            mailim.To.Add("serkanbahtiyar701@gmail.com");
            mailim.From = new MailAddress("serkanbahtiyar701@gmail.com");
            mailim.Subject = model.baslik;
            mailim.Body ="İsim: "+model.ad+"<br>"+ "soyad: "+model.soyad +"<br>" + model.icerik;
            mailim.IsBodyHtml = true;
            
            
            smtpClient.Send(mailim);
         
            return PartialView();
        }
   
    }
}