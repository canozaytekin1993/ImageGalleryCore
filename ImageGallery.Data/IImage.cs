using System.Collections.Generic;
using ImageGallery.Data.Models;

namespace ImageGallery.Data
{
    public interface IImage
    {
        IEnumerable<GalleryImage> GetAll();
        IEnumerable<GalleryImage> GetWithTag(string tag);
        GalleryImage GetById(int id);

    }
}