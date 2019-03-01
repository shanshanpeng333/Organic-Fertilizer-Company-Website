﻿using System;
using System.Collections.Generic;

namespace FourthDimensionOEC.Models
{
    public partial class Crop
    {
        public Crop()
        {
            Variety = new HashSet<Variety>();
        }

        public int CropId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public ICollection<Variety> Variety { get; set; }
    }
}
