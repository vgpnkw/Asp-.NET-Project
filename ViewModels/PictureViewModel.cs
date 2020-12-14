using System;
using Microsoft.AspNetCore.Http;

namespace WikiPedia.ViewModels
{
    public class PictureViewModel
    {
        public string PicturePrevName { get; set; }
        public string PictureName { get; set; }
        public string PictureText { get; set; }
        public int Type { get; set; }
        public IFormFile Image { get; set; }
    }
}
