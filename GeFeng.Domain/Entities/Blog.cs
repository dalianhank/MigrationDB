using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace GeFeng.Domain.Entities
{
    public class Blog
    {
        [HiddenInput(DisplayValue = false)]
        public int BlogId { get; set; }
        
        /**  enum blogcategory**/
       

       [Required(ErrorMessage = "Please enter blog catagory tag")]
        public string BlogCategory { get; set; }

        public string BlogTag { get; set; }

        [Required(ErrorMessage = "Please enter blog title")]
        public string BlogTitle { get; set; }

        [AllowHtml]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter blog Message")]
        public string BlogContent { get; set; }

        [HiddenInput(DisplayValue = false)]
        public DateTime BlogCreateDate { get; set; }

        public byte[] BlogImageData { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string BlogImageMimeType { get; set; }

        public List<Comment> Comments { get; set; }
    }

   
}
