using System;
using WikiPedia.Data;
using WikiPedia.Models;
using WikiPedia.Interfaces;
using System.Collections.Generic;
using System.Linq;
namespace WikiPedia.Repositories
{
    public class PublicationRepository : IGetPublication
    {
        private readonly PublicationContext _publicationContext;
        public PublicationRepository(PublicationContext publicationContext)
        {
            _publicationContext = publicationContext;
        }
        public Publication GetObjectPublication(int id) => _publicationContext.Publications.FirstOrDefault(p => p.Id == id);
        public List<Publication> GetAllPublications => _publicationContext.Publications.ToList();
    }

}