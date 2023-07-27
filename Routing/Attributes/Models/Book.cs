using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace Attributes.Models
{
    [DisplayColumn("Title")]
    public class Book
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [ReadOnly(true)]
        [Display(Name = "Book Title")]
        public string Title { get; set; }

        [Display(Name = "Author Name")]
        public string Author { get; set; }

        [Display(Name = "Publication Year")]
        [UIHint("PublicationYear")] // Apply the custom UI template

        public int PublicationYear { get; set; }

        [Display(Name = "Publication Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)] // Using DataType attribute to specify that it represents a date.

        public DateTime PublicationDate { get; set; }
    }
}