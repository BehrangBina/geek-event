﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeekEvent.Models
{
    public class Gig
    {
        public ApplicationUser Artist { get; set; }
        public DateTime DateTime { get; set; }
        public String Venue { get; set; }
        public Genre Genre { get; set; }
    }
}