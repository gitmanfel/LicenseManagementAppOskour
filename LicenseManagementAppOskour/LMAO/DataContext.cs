using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LMAO
{
    public class DataContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public DataContext() : base("name=DataContext")
        {
        }

        public System.Data.Entity.DbSet<LicenseManagementAppOskour.Models.License> Licenses { get; set; }

        public System.Data.Entity.DbSet<LicenseManagementAppOskour.Models.Media> Media { get; set; }

        public System.Data.Entity.DbSet<LicenseManagementAppOskour.Models.Film> Films { get; set; }

        public System.Data.Entity.DbSet<LicenseManagementAppOskour.Models.Book> Books { get; set; }

        public System.Data.Entity.DbSet<LicenseManagementAppOskour.Models.Game> Games { get; set; }

        public System.Data.Entity.DbSet<LicenseManagementAppOskour.Models.Music> Musics { get; set; }
    }
}
