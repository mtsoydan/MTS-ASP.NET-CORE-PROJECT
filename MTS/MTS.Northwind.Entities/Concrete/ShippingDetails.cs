using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MTS.Northwind.Entities.Concrete
{
    public class ShippingDetails
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public String LastName { get; set; }
        [Required]
        public string City { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        [Range(15,56)]
        public int Age { get; set; }
    }
}
