using System;
using System.Collections.Generic;
using WikiPedia.Models;

namespace WikiPedia.Interfaces
{
    public interface IGetPublication
    {
        Publication GetObjectPublication(int id);
        List<Publication> GetAllPublications { get; }
    }
}
