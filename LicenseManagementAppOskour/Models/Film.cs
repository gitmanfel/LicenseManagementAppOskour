using LicenseManagementAppOskour.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LicenseManagementAppOskour.Models
{
    public class Film : Media
    {
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh\\:mm}")]
        public TimeSpan Length { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public List<string> Actucers { get; set; }
        public MovieType Type { get; set; }
        public string Studio { get; set; }
        public double Budget { get; set; }

    }
}