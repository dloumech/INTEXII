﻿using System;
using System.Collections.Generic;

#nullable disable

namespace INTEXII.Models
{
    public partial class TextilefunctionTextile
    {
        public long MainTextilefunctionid { get; set; }
        public Textilefunction Textilefunction { get; set; }
        public long MainTextileid { get; set; }
        public Textile Textile { get; set; }
    }
}
