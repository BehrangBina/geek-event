using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeekEvent.ViewModel
{
    public class GigFormViewModel
    {
        //Helper Cless combines seperated date time to one field
        public string Venu { get; set; }
        public string Date  { get; set; }
        public string Time { get; set; }
    }
}