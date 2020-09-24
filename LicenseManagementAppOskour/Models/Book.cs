using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LicenseManagementAppOskour.Models
{
    public class Book : Media
    {
        public string Author { get; set; }

        public int NumberOfPages { get; set; }

        public string ISBN { get; set; }


    }
}