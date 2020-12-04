using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WikiPedia.Data;
using WikiPedia.Models;

namespace WikiPedia.Controllers
{
    public class HomeController : Controller
    {

        private  PublicationContext db;
        private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(ILogger<HomeController> logger, PublicationContext contextArt)
        {
            db = contextArt;
            //dbUsers = contextApp;
            _logger = logger;
            //this.hubContext = hubContext;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult Index(string name)
        {
            var publications = string.IsNullOrEmpty(name) ? db.Publications.ToList() : db.Publications.Where(p => p.Name.Contains(name)).ToList();
            foreach (var item in publications)
            {
                item.Image = db.Pictures.FirstOrDefault(x => x.Name == item.ImageName);
            }
            return View(publications);
        }
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Publication publication = await db.Publications.FirstOrDefaultAsync(p => p.Id == id);
                publication.Parts = db.PartsInfo.Where(x => x.PublicationId == publication.Id).ToList();
                var Pictures = db.Pictures;
                publication.Image = Pictures.FirstOrDefault(x => x.Name == publication.ImageName);
                foreach (var item in publication.Parts)
                {
                    if (item.PatrImageName == null)
                        item.Image = Pictures.FirstOrDefault(x => x.Name == "Def1");
                    else
                        item.Image = Pictures.FirstOrDefault(x => x.Name == item.PatrImageName);
                }
                if (publication != null)
                    return View(publication);
            }

            return NotFound();
        }


        [Authorize(Roles ="admin")]
        public async Task<IActionResult> Edit(int id)
        {
            if (id != 0)
            {
                Publication publication = await db.Publications.FirstOrDefaultAsync(p => p.Id == id);
                if (publication != null)
                {
                    publication.Parts = db.PartsInfo.Where(x => x.PublicationId == publication.Id).ToList();
                    return View(publication);
                }
            }
            else
            {
                Publication publication = new Publication();
                db.Publications.Add(publication);
                await db.SaveChangesAsync();
                return View(publication);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Publication publication)
        {
            db.Publications.Update(publication);
            if (string.IsNullOrEmpty(publication.ImageName))
            {
                publication.ImageName = "DefIco";
            }
            publication.Image = db.Pictures.FirstOrDefault(x => x.Name == publication.ImageName);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Publication article = new Publication { Id = id.Value };
                db.Entry(article).State = EntityState.Deleted;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
