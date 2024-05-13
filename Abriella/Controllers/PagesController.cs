using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;
namespace Abriella.Controllers
{
    public class PagesController : Controller
    {
        //
        // GET: /Pages/

        public ActionResult Pricing()
        {
            return View();
        }

        [HttpGet]
        public ActionResult FAQ()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FAQ(string subject, string message, string name, string email, string contact)
       {

            try
            {

                if (ModelState.IsValid)
                {
                    var senderemail = new MailAddress("demo7899999@gmail.com", "Customer Message");
                    var receiveremail = new MailAddress("bluemoonsoftware.io@gmail.com", "Receiver");
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
    

        public ActionResult OurTeam()
        {
            return View();
        }


        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult SingleProjects()
        {
            return View();
        }

        public ActionResult CaseStudy()
        {
            return View();
        }

        public ActionResult CaseTwoColumns()
        {
            return View();
        }

        public ActionResult SingleCase()
        {
            return View();
        }

        public ActionResult Testimonial()
        {
            return View();
        }

        public ActionResult OurClients()
        {
            return View();
        }

        public ActionResult Careers()
        {
            return View();
        }


        public ActionResult Products()
        {
            return View();
        }

        public ActionResult SingleProducts()
        {
            return View();
        }

        public ActionResult Cart()
        {
            return View();
        }

        public ActionResult Checkout()
        {
            return View();
        }

        public ActionResult Authentication()
        {
            return View();
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

        public ActionResult MyAccount()
        {
            return View();
        }

        public ActionResult MyOrders()
        {
            return View();
        }

        public ActionResult MyAddresses()
        {
            return View();
        }

        public ActionResult DemoProducts()
        {
            return View();
        }

        public ActionResult Feedback()
        {
            return View();
        }

        public ActionResult Termofservice()
        {
            return View();
        }

        public ActionResult PrivicyPolicy()
        {
            return View();
        }

        public ActionResult SearchPage()
        {
            return View();
        }

        public ActionResult Error404()
        {
            return View();
        }

        public ActionResult ComingSoon()
        {
            return View();
        }

    }
}