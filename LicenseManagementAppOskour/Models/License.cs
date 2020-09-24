using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LicenseManagementAppOskour.Models
{
    public class License
    {
        public License()
        {
            Medias = new List<Media>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime CreationDate { get; set; }

        public string Ownership { get; set; }

        public List<Media> Medias { get; set; }
    }
}