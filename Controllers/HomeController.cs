﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WikiPedia.Data;
using WikiPedia.Models;
using WikiPedia.signalR;
using WikiPedia.ViewModels;

namespace WikiPedia.Controllers
{
    public class HomeController : Controller
    {
        IHubContext<ChatHub> hubContext;
        private  PublicationContext db;
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext dbUsers;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(ILogger<HomeController> logger, PublicationContext contextArt, ApplicationDbContext contextApp, IHubContext<ChatHub> hubContext)
        {
            db = contextArt;
            dbUsers = contextApp;
            _logger = logger;
            this.hubContext = hubContext;
            
        }

        

        public IActionResult Privacy()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<IActionResult> Create(Publication publication)
        {
            db.Publications.Add(publication);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public ActionResult Index(string name)
        {
            var publications = string.IsNullOrEmpty(name) ? db.Publications.ToList() : db.Publications.Where(p => p.Name.Contains(name)).ToList();
            foreach (var item in publications)
            {
                item.Image = db.Pictures.FirstOrDefault(x => x.PictureName == item.ImageName);
                item.Parts = db.PartsInfo.Where(x => x.PublicationId == item.Id).ToList();
                foreach (var part in item.Parts)
                {
                    part.PublicationName = item.Name;
                }
            }
            IdentityUser user = dbUsers.Users.ToList().FirstOrDefault(g => g.UserName == User.Identity.Name);

            SearchPublication dataPublications = new SearchPublication();
            dataPublications.Publications = publications;
            dataPublications.User = user;
            db.SaveChanges();
            return View(dataPublications);
        }
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Publication publication = await db.Publications.FirstOrDefaultAsync(p => p.Id == id);
                publication.Parts = db.PartsInfo.Where(x => x.PublicationId == publication.Id).ToList();
                var Pictures = db.Pictures;
                publication.Image = Pictures.FirstOrDefault(x => x.PictureName == publication.ImageName);
                foreach (var item in publication.Parts)
                {
                    if (item.PatrImageName == null)
                        item.Image = Pictures.FirstOrDefault(x => x.PictureName == "DefIco");
                    else
                        item.Image = Pictures.FirstOrDefault(x => x.PictureName == item.PatrImageName);
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
                    DataClass.TempPublication = publication;
                    return View(publication);
                }
            }
            else
            {
                Publication publication = new Publication();
                publication.Name = "New publication";
                publication.Parts = DataClass.PartTempList;
                DataClass.TempPublication = publication;
                
                return View(publication);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Publication publication)
        {
            NewPublication(publication);

            if (string.IsNullOrEmpty(publication.ImageName))
            {
                publication.ImageName = "DefIco";
            }
            publication.Image = db.Pictures.FirstOrDefault(x => x.PictureName == publication.ImageName);
            if (DataClass.PartTempList != null)
            {
                foreach (var item in DataClass.PartTempList)
                {
                    item.PublicationId = publication.Id;
                    NewPart(item);
                }
                DataClass.PartTempList.Clear();
            }

            if (DataClass.ImagesTempList.Count != 0)
            {
                foreach (var item in DataClass.ImagesTempList)
                {
                    Picture delPict = db.Pictures.FirstOrDefault(x => x.PictureName == item.PictureName);
                    if (delPict != null)
                    {
                        db.Pictures.Remove(delPict);

                    }
                    NewImage(item);
                }
                DataClass.ImagesTempList.Clear();
            }

            var blocks = db.PartsInfo.Where(x => x.PublicationId == publication.Id).ToList();
            foreach (var item in blocks)
            {
                publication.Parts.Add(item);
            }

            if (publication.Parts != null)
            {
                foreach (var item in publication.Parts)
                {
                    item.PublicationId = publication.Id;
                }

            }
            await db.SaveChangesAsync();
            DataClass.TempPublication = null;
            await hubContext.Clients.All.SendAsync("Notify", $"В {DateTime.Now.ToShortTimeString()} была добавлена статья под названием {publication.Name}.");
            return RedirectToAction("Index");
        }

        [HttpPost]
        public void NewPublication(Publication publication)
        {
            db.Publications.Update(publication);
            db.SaveChanges();
        }


        [HttpPost]
        public void NewPart(PartInfo partInfo)
        {
            db.PartsInfo.Update(partInfo);
            db.SaveChanges();
        }

        [HttpPost]
        public void NewImage(Picture picture)
        {
            db.Pictures.Update(picture);
            db.SaveChanges();
        }

        [Authorize(Roles ="admin")]
        [HttpGet, ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Publication publication = await db.Publications.FirstOrDefaultAsync(p => p.Id == id);
                if (publication != null)
                    return View(publication);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Publication publication = new Publication { Id = id.Value };
                db.Entry(publication).State = EntityState.Deleted;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return NotFound();
        }


        [HttpGet, ActionName("DeletePart")]
        public async Task<IActionResult> ConfirmDeletePart(int idPart, string name)
        {
            if (idPart != 0)
            {
                PartInfo partInfo = await db.PartsInfo.FirstOrDefaultAsync(p => p.PartInfoId == idPart);
                if (partInfo != null)
                    return View(partInfo);
            }
            else
            {
                var part = DataClass.PartTempList.FirstOrDefault(p => p.PartName == name);
                return View(part);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeletePart(int idPart, string name)
        {
            if (idPart != 0)
            {
                PartInfo partInfo = await db.PartsInfo.FirstOrDefaultAsync(p => p.PartInfoId == idPart);
                if (partInfo != null)
                {
                    db.PartsInfo.Remove(partInfo);
                    await db.SaveChangesAsync();
                    Publication publication = await db.Publications.FirstOrDefaultAsync(p => p.Id == partInfo.PublicationId);
                    publication.Parts = db.PartsInfo.Where(x => x.PublicationId == publication.Id).ToList();
                    return View("Edit", publication);
                }
            }
            else
            {
                var part = DataClass.PartTempList.FirstOrDefault(p => p.PartName == name);
                DataClass.PartTempList.Remove(part);
                DataClass.TempPublication.Parts.Remove(part);
                return View("Edit", DataClass.TempPublication);
            }
            return NotFound();
        }

        public async Task<IActionResult> EditPart(int idPart, string partName)
        {
            if (idPart != 0)
            {
                PartInfo partInfo = await db.PartsInfo.FirstOrDefaultAsync(p => p.PartInfoId == idPart);
                if (partInfo != null)
                {
                    
                    return View(partInfo);
                }
            }
            else
            {
                if (partName != null)
                {
                    PartInfo partInfo = DataClass.PartTempList.FirstOrDefault(p => p.PartName == partName);
                    partInfo.PrevName = partInfo.PartName;
                    return View(partInfo);
                }
                else
                {
                    PartInfo partInfo = new PartInfo();
                    partInfo.PublicationName = DataClass.TempPublication.Name;
                    return View(partInfo);

                }

            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> EditPart(PartInfo partInfo)
        {

            if (string.IsNullOrEmpty(partInfo.PatrImageName))
            {
                partInfo.PatrImageName = "DefIco";
            }

            Publication publication = new Publication();
            if (partInfo.PublicationId != 0)
            {
                publication = await db.Publications.FirstOrDefaultAsync(p => p.Id == partInfo.PublicationId);
            }
            else
            {
                publication = DataClass.TempPublication;
            }



            if (db.Publications.FirstOrDefault(p => p.Name == partInfo.PublicationName) != null)
            {
                partInfo.PublicationId = publication.Id;
                db.PartsInfo.Update(partInfo);
                await db.SaveChangesAsync();
                publication.Parts = db.PartsInfo.Where(x => x.PublicationName == publication.Name).ToList();
            }
            else
            {
                PartInfo deletePartInfo = DataClass.PartTempList.FirstOrDefault(p => p.PartName == partInfo.PrevName);
                DataClass.PartTempList.Remove(deletePartInfo);
                DataClass.PartTempList.Add(partInfo);
                publication.Parts = DataClass.PartTempList;
            }
            DataClass.TempPart = null;
            return View("Edit", publication);
        }

        public async Task<ActionResult> EditPicture(string pictureName, int type)
        {
            if (pictureName != null)
            {
                Picture picture = await db.Pictures.FirstOrDefaultAsync(p => p.PictureName == pictureName);
                if (picture == null)
                {
                    picture = DataClass.ImagesTempList.FirstOrDefault(p => p.PictureName == pictureName);
                }
                if (picture != null)
                {
                    PictureViewModel pictureLoad = new PictureViewModel();
                    pictureLoad.PictureText = picture.PictureText;
                    pictureLoad.PictureName = picture.PictureName;
                    pictureLoad.PicturePrevName = pictureLoad.PictureName;
                    pictureLoad.Type = type;
                    return View(pictureLoad);
                }
            }
            else
            {
                PictureViewModel picture = new PictureViewModel();
                picture.PictureName = "New picture";
                picture.Type = type;
                if (type == 1)
                {
                    DataClass.TempPublication.ImageName = picture.PictureName;
                }
                else
                {
                    DataClass.TempPart.PatrImageName = picture.PictureName;
                }
                return View(picture);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> EditPicture(PictureViewModel pictureLoad)
        {
            Picture picture = new Picture();
            if (pictureLoad.PicturePrevName != null)
            {
                picture = db.Pictures.FirstOrDefault(x => x.PictureName == pictureLoad.PicturePrevName);
                if (picture == null)
                {
                    picture = DataClass.ImagesTempList.FirstOrDefault(p => p.PictureName == pictureLoad.PicturePrevName);
                }
            }

            if (pictureLoad.PictureName != null)
                picture.PictureName = pictureLoad.PictureName;
            if (pictureLoad.PictureText != null)
                picture.PictureText = pictureLoad.PictureText;
            if (pictureLoad.Image != null)
            {
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(pictureLoad.Image.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)pictureLoad.Image.Length);
                }

                // установка массива байтов
                picture.Image = imageData;
            }

            DataClass.ImagesTempList.Add(picture);


            if (pictureLoad.Type == 1)
            {
                DataClass.TempPublication.ImageName = pictureLoad.PictureName;
                return View("Edit", DataClass.TempPublication);
            }
            DataClass.TempPart.PatrImageName = pictureLoad.PictureName;
            return View("EditPart", DataClass.TempPart);

        }
    }
}
