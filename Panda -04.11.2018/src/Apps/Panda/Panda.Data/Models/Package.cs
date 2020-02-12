using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Panda.Data.Models
{
    public class Package
    {
        public string Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Description  { get; set; }

        public decimal? Weight  { get; set; }

        public string ShippingAddress { get; set; }
    }
}
