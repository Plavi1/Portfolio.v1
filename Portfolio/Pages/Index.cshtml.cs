using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using System.Net.Mail;
using Portfolio.Models;

namespace Portfolio.Pages
{
    public class IndexModel : PageModel
    {


        public void OnGet()
        {

        }
        [BindProperty]
        public Sender sendmail { get; set; }
        public async Task OnPost()
        {
            if (ModelState.IsValid)
            {
                string To = "nemanjaplavsic378@yahoo.com";
                string Subject = sendmail.Subject;
                string Body = " Name:" + sendmail.Name + "\n Email:" + sendmail.Email + "\n Body:" + sendmail.Body;

                MailMessage mm = new MailMessage();
                mm.To.Add(To);
                mm.Subject = Subject;
                mm.Body = Body;
                mm.IsBodyHtml = false;
                mm.From = new MailAddress("ulicnibasket12@gmail.com");
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;          //dont work with true: Credentials are necessary if the server requires the client to authenticate before it will send email on the client's behalf.                                                            
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential("ulicnibasket12@gmail.com", "22Numericki!"); 
                await smtp.SendMailAsync(mm);
            }

        }
    }
}
