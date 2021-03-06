﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeekEvent.ViewModel
{
    public class GigFormViewModel
    {
        //Helper Class combines seperated date time to one field
        [Required]
        public string Venue { get; set; }
        [Required]
        [FutureDate]
        public string Date  { get; set; }
        [Required]
        [FutureTime]
        public string Time { get; set; }
        [Required]
        public int Genre { get; set; }
        public IEnumerable<Models.Genre> Genres { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));

        }
    }

}