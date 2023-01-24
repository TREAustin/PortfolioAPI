using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioAPI.Models;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace PortfolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("IsContacting")]
        public bool IsContacting(Contact contact)
        {
            if (contact == null)
            {
                return false;
            }

            try
            {
                MailMessage msg = new()
                {
                    From = new MailAddress(contact.Email)
                };
                msg.Subject = $"{contact.Name} is reaching out.";
                msg.IsBodyHtml = true;
                msg.To.Add(new MailAddress("tausti0065@gmail.com"));
                msg.Body = "<h2>Name: " + contact.Name + "</h2><h2>Email: " + contact.Email + "</h2><h2>" + contact.Reason + "</h2>";
                msg.Sender = new MailAddress(contact.Email);

                SmtpClient smtpClient = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    EnableSsl = true,
                    Credentials = new NetworkCredential("tausti0065@gmail.com", "lbvtmfrfmzveihks")
                };
                smtpClient.Send(msg);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }

            return true;
        }
    }
}
