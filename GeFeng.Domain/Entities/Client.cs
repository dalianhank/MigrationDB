using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace GeFeng.Domain.Entities
{
    public class Client
    {
        [ScaffoldColumn(false)]
        [Key]
        public int ClientId { get; set; }

        [HiddenInput(DisplayValue = false)]
        public DateTime CreateDate { get; set; }

        
        public string UserName { get; set; }


        [Required(ErrorMessage = "First Name is required")]
        [DisplayName("First Name")]
        [StringLength(160)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last is required")]
        [DisplayName("Last Name")]
        [StringLength(160)]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "Country is required")]
        [StringLength(40)]
        public string Country { get; set; }
        
        [StringLength(70)]
        public string Address { get; set; }

        
        [StringLength(40)]
        public string City { get; set; }

        
        [StringLength(40)]
        public string State { get; set; }

        
        
        [StringLength(10)]
        public string PostalCode { get; set; }

        

        
        [StringLength(24)]
        public string Phone { get; set; }

        

    }
}