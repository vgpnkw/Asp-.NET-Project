﻿using System;
namespace WikiPedia.Models
{
    public class PartInfo
    {
        public int PartInfoId { get; set; }
        public string PartName { get; set; }
        
        public string PrevName { get; set; }
        public string Text { get; set; }
        public string PatrImageName { get; set; }
        public Picture Image { get; set; }
        public int PublicationId { get; set; }
        //public byte[] Avatar { get; set; }      
        public string PublicationName { get; set; }
    }
}
