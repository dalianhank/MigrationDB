using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace GeFeng.Domain.Entities
{
    public class Comment
    {
        [HiddenInput(DisplayValue = false)]
        public int CommentId { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int BlogId { get; set; }

        [HiddenInput(DisplayValue = false)]
        public DateTime CommentCreateDate { get; set; }

        [Required(ErrorMessage = "Please enter a user name")]
        [DisplayName("Comment User Name")]
        public string CommentUser { get; set; }
        
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter your Comment")]
        [DisplayName("Post a Comment")]
        public string CommentCotent { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
