using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace GeFeng.Domain.Entities
{
    public class Contact
    {
        [HiddenInput(DisplayValue = false)]
        public int ContactId { get; set; }

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Email is is not valid.")]
        [DataType(DataType.EmailAddress)]
        public string ContactEmail { get; set; }

        
        public DateTime ContactCreateDate { get; set; }

        [Required(ErrorMessage = "Please enter your message!")]
        public string ContactMessage { get; set; }
    }
}
