using System;
namespace WikiPedia.Models
{
    public class Picture
    {
        public int PictureId { get; set; }
        public string PictureName { get; set; }
        public string Path { get; set; }
        public string PictureText { get; set; }
        public byte[] Image { get; set; }
    }
}
