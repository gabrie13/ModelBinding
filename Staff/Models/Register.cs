using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Staff.Models
{
    public class Register
    {
        public int RegisterId { get; set; }

        public int PersonId { get; set; }

        public decimal Cash { get; set; }

        public decimal Check { get; set; }

        public decimal Visa { get; set; }

        public decimal Mastercard { get; set; }

        public decimal Discover { get; set; }

        public decimal Amex { get; set; }

        public decimal GiftCard { get; set; }

        public decimal Tax { get; set; }

        public DateTime Date { get; set; }

        public virtual Person Person { get; set; }
    }
}