using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MTS.Northwind.AspMvcCoreUI.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
         [DataType(DataType.Password)]
        public string PassWord { get; set; }
        //[Required]
        //[DataType(DataType.Password)]
        //public string ConfirmPassWord { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
