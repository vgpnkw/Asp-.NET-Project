using System;
namespace WikiPedia.Models
{
    public class Textpart
    {
        public int TextpartId { get; set; }
        public string BlockName { get; set; }
        public int PrevId { get; set; }
        public string Text { get; set; }
        public string PartImageName { get; set; }
        public Picture Image { get; set; }
        public int PublicationId { get; set; }
    }
}
