using System;
using Microsoft.AspNetCore.Mvc;
using MailKit;
using MailKit.Net.Smtp;
using MimeKit;
using System.Collections.Generic;

namespace WikiPedia.Controllers
{
    public class AnnouncmentController : Controller
    {



        public AnnouncmentController()
        {

        }



        public IActionResult Index([FromForm] string message)
        {

            return View();
        }

        /*[HttpPost("/announcment")]
        public async Task<IActionResult> Post([FromForm] string message)
        {
            int chatid = 310145490;
            await _telegramBotClient.SendTextMessageAsync(chatid, message);
            await _hubcontext.Clients.All.SendAsync("ReceiveMessage", message);
            
            return RedirectToAction("Index");
        }*/

        [HttpPost("/announcment")]
        public IActionResult Post([FromForm] string body, string message)
        {
            var msg = new MimeMessage();
            List<string> recepients = new List<string>() { "naskidashvilisaba370@gmail.com", "gapankoff@gmail.com" };
            msg.From.Add(new MailboxAddress("Admin", "gapankoff@gmail.com"));
            foreach (var rec in recepients)
            {
                msg.To.Add(new MailboxAddress("Training academy", rec));
            }

            msg.Subject = body;
            msg.Body = new TextPart("plain")
            {
                Text = message

            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);

                client.Authenticate("gapankoff@gmail.com", "2281337A");

                client.Send(msg);
                client.Disconnect(true);
            }

            return RedirectToAction("Index");
        }
    }
}
