using ImageGallery.Data.Models;
using ImageGallery.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ImageGallery.UI.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var hikingImageTags = new List<ImageTag>();
            var cityImageTags = new List<ImageTag>();

            var tag1 = new ImageTag()
            {
                Description = "Adventure",
                Id = 0
            };

            var tag2 = new ImageTag()
            {
                Description = "Urban",
                Id = 1
            };

            var tag3 = new ImageTag()
            {
                Description = "New York",
                Id = 2
            };

            hikingImageTags.Add(tag1);
            cityImageTags.AddRange(new List<ImageTag> { tag2, tag3 });

            var imagesList = new List<GalleryImage>()
            {
                new GalleryImage()
                {
                    Title = "Hiking Trip",
                    Url = "https://images.pexels.com/photos/2351075/pexels-photo-2351075.jpeg?auto=format%2Ccompress&cs=tinysrgb&h=750&w=1260",
                    Created = DateTime.Now,
                    Tags = hikingImageTags
                },
                new GalleryImage()
                {
                    Title = "On The Trail",
                    Url = "https://images.pexels.com/photos/2420555/pexels-photo-2420555.jpeg?auto=compress&cs=tinysrgb&h=750&w=1260",
                    Created = DateTime.Now,
                    Tags = hikingImageTags
                },
                new GalleryImage()
                {
                    Title = "Downtown",
                    Url = "https://images.pexels.com/photos/2364590/pexels-photo-2364590.jpeg?auto=compress&cs=tinysrgb&h=750&w=1260",
                    Created = DateTime.Now,
                    Tags = cityImageTags
                },
            };

            var model = new GalleryIndexModel()
            {
                Images = imagesList,
                SearchQuery = ""
            };
            return View();
        }
    }
}