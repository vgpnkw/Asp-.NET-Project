using System;
namespace WikiPedia.Models
{
    public class Picture
    {
        public int PictureId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Text { get; set; }
        public byte[] Image { get; set; }
    }
}
