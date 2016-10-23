﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace GeekEvent.ViewModel
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(
                Convert.ToString(value),
                "d mmm yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None, out dateTime
            );

            return (isValid && dateTime > DateTime.Now);
        }
    }
}