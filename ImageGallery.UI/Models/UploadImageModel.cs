using Microsoft.AspNetCore.Http;

namespace ImageGallery.UI.Models
{
    public class UploadImageModel
    {
        public string Title { get; set; }
        public string Tags { get; set; }
        public IFormFile ImageUpload { get; set; }
    }
}