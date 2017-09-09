using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Staff.Models
{ 
    public class Register
    {
        [Key]
        public int RegisterId { get; set; }
        
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal Cash { get; set; }

        [DataType(DataType.Currency)] 
        public decimal Check { get; set; }

        [DataType(DataType.Currency)]
        public decimal Visa { get; set; }

        [DataType(DataType.Currency)]
        public decimal Mastercard { get; set; }

        [DataType(DataType.Currency)]
        public decimal Discover { get; set; }

        [DataType(DataType.Currency)]
        public decimal Amex { get; set; }

        [DataType(DataType.Currency)]
        public decimal GiftCard { get; set; }

        [DataType(DataType.Currency)]
        public decimal Tax { get; set; }

        public virtual Person Person { get; set; }

    }
}