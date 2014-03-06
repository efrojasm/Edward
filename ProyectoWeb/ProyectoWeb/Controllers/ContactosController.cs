using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoWeb.Models;
using System.Net.Mail;
using System.Net;

namespace ProyectoWeb.Controllers
{
    public class ContactosController : Controller
    {
        private ProyectoDb db = new ProyectoDb();
        //
        // GET: /Contactos/

        public ActionResult Index()
        {
            List<Contacto> Contactos = db.Contactos.ToList();
            ViewBag.contactos = Contactos;
            return View();

        }

        public static void RetryIfBusy(string correo="",string mensaje="",string nombre="")
        {
            MailAddress from = new MailAddress(correo);
            MailAddress to = new MailAddress("efrojasm@gmail.com");
            MailMessage message = new MailMessage(from, to);
            // message.Subject = "Using the SmtpClient class.";
            message.Subject = "Contacto";
            message.Body = @nombre+"\n"+mensaje;
            // Add a carbon copy recipient.
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            // Include credentials if the server requires them.
            Console.WriteLine("Sending an e-mail message to {0} using the SMTP host {1}.",
                 to.Address, client.Host);
            try
            {
                client.Send(message);
            }
            catch (SmtpFailedRecipientsException ex)
            {
                for (int i = 0; i < ex.InnerExceptions.Length; i++)
                {
                    SmtpStatusCode status = ex.InnerExceptions[i].StatusCode;
                    if (status == SmtpStatusCode.MailboxBusy ||
                        status == SmtpStatusCode.MailboxUnavailable)
                    {
                        Console.WriteLine("Delivery failed - retrying in 5 seconds.");
                        System.Threading.Thread.Sleep(5000);
                        client.Send(message);
                    }
                    else
                    {
                        Console.WriteLine("Failed to deliver message to {0}",
                            ex.InnerExceptions[i].FailedRecipient);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in RetryIfBusy(): {0}",
                        ex.ToString());
            }
        }


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);

        }



    }
}
