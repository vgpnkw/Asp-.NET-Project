using System;
using System.Collections.Generic;

namespace WikiPedia.Models
{
    public class Publication
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShirtInfo { get; set; }
        public string Info { get; set; }
        public string ImageName { get; set; }
        public List<PartInfo> Parts { get; set; }
        public Picture Image { get; set; }
        public string UserId { get; set; }

    }
}
