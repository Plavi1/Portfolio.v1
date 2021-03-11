using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using Portfolio.Models;
using System.ComponentModel.DataAnnotations;

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
                string To = "me@myacc.com";                       // set up the email you want to receive
                string Subject = sendmail.Subject;
            string Body = " Name:"+ sendmail.Name +"\n Email:"+sendmail.Email+"\n Body:" + sendmail.Body;

            MailMessage mm = new MailMessage();
            mm.To.Add(To);                                        
            mm.Subject = Subject;
            mm.Body = Body;
            mm.IsBodyHtml = false;
            mm.From = new MailAddress("abc@abc.bc");                       //an email that will send mail
                SmtpClient smtp = new SmtpClient("smtp.gmail.com"); //DONT TOUCH
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;          //dont work with true: Credentials are necessary if the server requires the client to authenticate before it will send email on the client's behalf.                                                            
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("abc@abc.bc", "password");  //email and pw (hide this if you post this cod public)  
            await smtp.SendMailAsync(mm);
            }

        }
    }
}
