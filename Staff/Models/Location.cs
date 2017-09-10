﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Staff.Models
{
    public class Location
    {
        public int LocationId { get; set; }

        [Display(Name = "Location")]
        public string LocationName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}