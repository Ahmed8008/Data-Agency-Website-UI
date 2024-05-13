using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;
namespace Abriella.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Contact(string subject, string message, string name, string email, string contact)
        {

            try
            {

                if (ModelState.IsValid)
                {
                    var senderemail = new MailAddress("demo7899999@gmail.com", "Customer Message");
                    var receiveremail = new MailAddress("ahmedusmani643@gmail.com", "Receiver");
                    var password = "bfapmnypsntylcde";
                    var sub = subject;
                    var N = "Name:";
                    var E = "Email:";
                    var P = "PhoneNumber:";
                    var M = "Message:";
                    var body = N + name + "\n" + E + email + "\n" + P + contact + "\n" + M + message;
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderemail.Address, password)

                    };

                    using (var mess = new MailMessage(senderemail, receiveremail)
                    {
                        Subject = subject,

                        Body = body






                    }
                )
                    {
                        smtp.Send(mess);
                    }

                    return View();

                }

            }

            catch (Exception)
            {
                ViewBag.Error = "There are some problems in sending email";
            }
            return View();

        }
    }
}
