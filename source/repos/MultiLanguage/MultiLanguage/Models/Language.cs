using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MultiLanguage.Models
{
    public class Language
    {
        [Key]
        public int LanguageID { get; set; }
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(150)]
        public string LanguageTitle { get; set; }

        public virtual List<Article> Articles { get; set; }

    }
}