using System;
using Microsoft.AspNetCore.Mvc;
using MailKit;
using MailKit.Net.Smtp;
using MimeKit;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Linq;

namespace WikiPedia.Controllers
{
    public class AnnouncmentController : Controller
    {
        UserManager<IdentityUser> _userManager;


        public AnnouncmentController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
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

        [HttpPost]
        public IActionResult Post([FromForm] string body, string message)
        {
            
            
            var msg = new MimeMessage();

            //List<> userStore = new UserStore<IdentityUser>();
            //var userManager = new UserManager<IdentityUser>(userStore);
            //IQueryable<IdentityUser> usersQuery = userManager.Users;
            //List<IdentityUser> users = usersQuery.ToList();

            //List<string> AllUsers = new List<string>() ;



            //foreach (var user in AllUsers)
            //{
            //    AllUsers.Add(user.)
            //}

            var allUsers = _userManager.Users.ToList();
            
            //List<string> recepients = new List<string>() { "h-vitalik2001@mail.ru", "gapankowwitalik@mail.ru" };
            
            msg.From.Add(new MailboxAddress("Admin", "gapankoff@gmail.com"));

            //List<string> recepients = new List<string>();
            //foreach (var user in allUsers)
            //{
            //    Console.WriteLine(user.Email);

            //}

            foreach (var user in allUsers)
            {

                msg.To.Add(new MailboxAddress("Training academy", user.ToString()));
            }
            //foreach (var rec in recepients)
            //{
            //    msg.To.Add(new MailboxAddress("Training academy", rec));
            //}
            //foreach (var user in AllUsers)
            //{
            //    msg.To.Add(new MailboxAddress("Training academy", user.NormalizedEmail));
            //}
            msg.To.Add(new MailboxAddress("Training academy", "h-vitalik2001@mail.ru" ));
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
