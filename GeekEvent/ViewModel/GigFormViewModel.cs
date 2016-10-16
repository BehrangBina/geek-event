using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeekEvent.ViewModel
{
    public class GigFormViewModel
    {
        //Helper Cless combines seperated date time to one field
        public string Venue { get; set; }
        public string Date  { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; }
        public IEnumerable<Models.Genre> Genres { get; set; }
    }

}