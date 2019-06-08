using ImageGallery.UI.Models;
using Microsoft.AspNetCore.Mvc;
using ImageGallery.Service;
using Microsoft.Extensions.Configuration;

namespace ImageGallery.UI.Controllers
{
    public class ImageController : Controller
    {
        private IConfiguration _configuration;
        private ImageService _imageService;
        private string DefaultConnectionString { get; }

        public ImageController(IConfiguration configuration, ImageService imageService)
        {
            _configuration = configuration;
            _imageService = imageService;
            DefaultConnectionString = _configuration["DefaultConnectionString"];
        }

        public IActionResult Upload()
        {
            var model = new UploadImageModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult UploadNewImage()
        {
            return Ok();
        }
    }
}