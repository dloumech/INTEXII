﻿using System;
using System.Collections.Generic;

#nullable disable

namespace INTEXII.Models
{
    public partial class ColorTextile
    {
        public long MainColorid { get; set; }
        public Color Color { get; set; }
        public long MainTextileid { get; set; }
        public Textile Textile { get; set; }

    }
}
