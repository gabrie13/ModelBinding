using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Staff.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [ForeignKey("Position")]
        public int PositionId { get; set; }

        [ForeignKey("Location")]
        public int LocationId { get; set; }
        
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Name
        {
            get
            {
                return String.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public virtual Position Position { get; set; }

        public virtual Location Location { get; set; }
    }
}