using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Staff.Models
{
    public class ShiftClose
    {
        [Key]
        public int ShiftCloseId { get; set; }

        [ForeignKey("Person")]
        [Display(Name = "Closing Manager")]
        public int PersonId { get; set; }

        [Display(Name = "Close Date")]
        [DataType(DataType.Date)]
        public DateTime ClosingDate { get; set; }

        [Display(Name = "Shift Notes")]
        public string ShiftNotes { get; set; }

        public virtual Person Person { get; set; }
    }
}