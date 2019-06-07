﻿using System;
using System.Collections.Generic;

namespace ImageGallery.Data.Models
{
    public class GalleryImage
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public string Url { get; set; }
        
        public virtual IEnumerable<ImageTag> Tags { get; set; }
    }
}