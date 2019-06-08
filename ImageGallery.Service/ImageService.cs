using ImageGallery.Data;
using ImageGallery.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ImageGallery.Service
{
    public class ImageService : IImage
    {
        private readonly ImageGalleryDbContext _context;

        public ImageService(ImageGalleryDbContext context)
        {
            _context = context;
        }

        public IEnumerable<GalleryImage> GetAll()
        {
            return _context.GalleryImages.Include(img => img.Tags);
        }

        public IEnumerable<GalleryImage> GetWithTag(string tag)
        {
            return GetAll().Where(x => x.Tags.Any(y => y.Description == tag));
        }

        public GalleryImage GetById(int id)
        {
            return GetAll().Where(x => x.Id == id).First();
        }
    }
}
