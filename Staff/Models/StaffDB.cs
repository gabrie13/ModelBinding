using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Staff.Models
{
    public class StaffDB : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public StaffDB() : base("name=StaffDB")
        {
        }

        public System.Data.Entity.DbSet<Staff.Models.Position> Positions { get; set; }

        public System.Data.Entity.DbSet<Staff.Models.Location> Locations { get; set; }

        public System.Data.Entity.DbSet<Staff.Models.Person> People { get; set; }

        public System.Data.Entity.DbSet<Staff.Models.Register> Registers { get; set; }

    }
}
