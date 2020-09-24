using LicenseManagementAppOskour.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LicenseManagementAppOskour.Models
{
    public class Music : Media
    {
        public MusicType Type { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm}")]
        public TimeSpan Length { get; set; }
    }
}