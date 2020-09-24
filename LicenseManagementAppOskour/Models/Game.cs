using LicenseManagementAppOskour.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LicenseManagementAppOskour.Models
{
    public class Game : Media
    {
        public GamePlatform Platform { get; set; }
        public string DiskSpace { get; set; }
        public GameType Type { get; set; }
        public string Studio { get; set; }
        public string Editor { get; set; }
        public GameRating Rating { get; set; }
    }
}