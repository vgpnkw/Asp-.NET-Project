using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace WikiPedia.Models
{
    public class SearchPublication
    {
        public IdentityUser User { get; set; }
        public List<Publication> Publications { get; set; }
    }
}
