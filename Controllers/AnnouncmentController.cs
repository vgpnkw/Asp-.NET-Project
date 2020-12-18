using System;
using Microsoft.AspNetCore.Mvc;
using MailKit;
using MailKit.Net.Smtp;
using MimeKit;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Linq;
using WikiPedia.Servises;
using WikiPedia.Models;

namespace WikiPedia.Controllers
{
    public class AnnouncmentController : Controller
    {
        UserManager<IdentityUser> _userManager;
        private readonly IEmailMessanger _emailMessenger;


        public AnnouncmentController(UserManager<IdentityUser> userManager, IEmailMessanger emailMessenger)
        {
            _userManager = userManager;
            _emailMessenger = emailMessenger;
        }



        public IActionResult Index([FromForm] string message)
        {

            return View();
        }


        //[HttpPost]
        //public IActionResult Post([FromForm] string body, string message)
        //{


        //    var msg = new MimeMessage();



        //    var allUsers = _userManager.Users.ToList();


        //    msg.From.Add(new MailboxAddress("Admin", "gapankoff@gmail.com"));



        //    foreach (var user in allUsers)
        //    {

        //        msg.To.Add(new MailboxAddress("Training academy", user.ToString()));
        //    }


        //    msg.Subject = body;
        //    msg.Body = new TextPart("plain")
        //    {
        //        Text = message

        //    };

        //    using (var client = new SmtpClient())
        //    {
        //        client.Connect("smtp.gmail.com", 587, false);

        //        client.Authenticate("gapankoff@gmail.com", "2281337A");

        //        client.Send(msg);
        //        client.Disconnect(true);
        //    }

        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public IActionResult Post([FromForm] string body, string message)
        {
            EmailMessage msg = new EmailMessage
            {
                From = "wikipediaclone",
                Subject = body,
                Content = message
            };

            var allUsers = _userManager.Users.ToList();

            foreach (var rec in allUsers)
            {
                msg.ToAddresses.Add(rec.ToString());
            }

            _emailMessenger.SendMsg(msg);

            return RedirectToAction("Index");
        }
    }
}
