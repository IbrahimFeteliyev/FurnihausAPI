﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class AddBlogDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverPhoto { get; set; }
        public string? Image { get; set; }
    }
}
