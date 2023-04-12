using System;
using System.Collections.Generic;

#nullable disable

namespace INTEXII.Models
{
    public partial class BurialmainTextile
    {

        public long MainBurialmainid { get; set; }
        public Burialmain Burialmain {get ;set;}
        public long MainTextileid { get; set; }
        public Textile Textile { get; set; }
    }
}
