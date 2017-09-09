using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Staff.Models
{
    public class StaffDbSetInitializer : DropCreateDatabaseAlways<StaffDB>
    {
        protected override void Seed(StaffDB context)
        {
            context.Positions.Add(new Position { PositionTitle = "Corporate Admin" });
            context.Positions.Add(new Position { PositionTitle = "Regional Manager" });
            context.Positions.Add(new Position { PositionTitle = "District Manager" });
            context.Positions.Add(new Position { PositionTitle = "General Manager" });
            context.Positions.Add(new Position { PositionTitle = "Assistant Manager" });
            context.Positions.Add(new Position { PositionTitle = "Kitchen Manager" });
            context.Positions.Add(new Position { PositionTitle = "Shift Lead" });
            context.Positions.Add(new Position { PositionTitle = "Prep Cook" });
            context.Positions.Add(new Position { PositionTitle = "Line Cook" });
            context.Positions.Add(new Position { PositionTitle = "Cashier" });
            context.Positions.Add(new Position { PositionTitle = "Lobby" });

            context.Locations.Add(new Location { LocationName = "Corporate",      Address = "Wasatch",    City = "Cottonwood",  State = "UT", ZipCode = "84037", Email = "corporate@email.com",  Phone = "801-555-2236" });
            context.Locations.Add(new Location { LocationName = "Sandy",          Address = "State St.",  City = "Sandy",       State = "UT", ZipCode = "84070", Email = "sandy@email.com",      Phone = "801-555-4571" });
            context.Locations.Add(new Location { LocationName = "Draper",         Address = "123rd So.",  City = "Draper",      State = "UT", ZipCode = "84092", Email = "draper@email.com",     Phone = "801-555-2235" });
            context.Locations.Add(new Location { LocationName = "Murray",         Address = "53rd So.",   City = "Murray",      State = "UT", ZipCode = "84336", Email = "murray@email.com",     Phone = "801-555-9964" });
            context.Locations.Add(new Location { LocationName = "Sugarhouse",     Address = "21st So.",   City = "Sugarhouse",  State = "UT", ZipCode = "84694", Email = "sugarhouse@email.com", Phone = "801-555-3368" });
            context.Locations.Add(new Location { LocationName = "Orem",           Address = "Prkway",     City = "Orem",        State = "UT", ZipCode = "84226", Email = "orem@email.com",       Phone = "801-555-1124" });
            context.Locations.Add(new Location { LocationName = "Provo",          Address = "Main St.",   City = "Provo",       State = "UT", ZipCode = "84712", Email = "provo@email.com",      Phone = "801-555-9942" });
            context.Locations.Add(new Location { LocationName = "Boise",          Address = "Center St.", City = "Boise",       State = "UT", ZipCode = "95463", Email = "boise@email.com",      Phone = "801-555-2259" });
            context.Locations.Add(new Location { LocationName = "Logan",          Address = "Hwy 89",     City = "Logan",       State = "UT", ZipCode = "11597", Email = "logan@email.com",      Phone = "801-555-5534" });
            context.Locations.Add(new Location { LocationName = "Bountiful",      Address = "500 West",   City = "Bountiful",   State = "UT", ZipCode = "84087", Email = "bountiful@email.com",  Phone = "801-555-7351" });
            context.Locations.Add(new Location { LocationName = "Riverdale",      Address = "Main St.",   City = "Ogden",       State = "UT", ZipCode = "66972", Email = "ogden@email.com",      Phone = "801-555-1498" });
            context.Locations.Add(new Location { LocationName = "Jordan Landing", Address = "78th So.",   City = "West Valley", State = "UT", ZipCode = "85234", Email = "westvalley@email.com", Phone = "801-555-1968" });
            

            base.Seed(context);
        }
    }
}