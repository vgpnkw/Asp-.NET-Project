using System;
using System.Collections.Generic;
using WikiPedia.Models;

namespace WikiPedia.Interfaces
{
    public interface IGetLiked
    {
        List<Publication> GetLiked(string id);
    }
}
