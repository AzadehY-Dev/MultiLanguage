using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MultiLanguage.Models
{
    public class Article
    {
        [Key]
        public int ArticleID { get; set; }
        [Required]
        public int LanguageID { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.Article), ErrorMessageResourceName = "RequiredTitle")]
        [MaxLength(250)]
        [Display(Name = "Title", ResourceType =typeof(Resources.Article))]
        public string Title { get; set; }
        [MaxLength(500)]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessageResourceType = typeof(Resources.Article), ErrorMessageResourceName = "RequiredText")]
        [Display(Name = "Text", ResourceType = typeof(Resources.Article))]
        public string Text { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.Article), ErrorMessageResourceName = "RequiredAuthor")]
        [Display(Name = "Author", ResourceType = typeof(Resources.Article))]
        public string Author { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.Article), ErrorMessageResourceName = "RequiredCreateDate")]
        [Display(Name = "CreateDate", ResourceType = typeof(Resources.Article))]
        public DateTime CreateDate { get; set; }

        public virtual Language Language { get; set; }
        public Article()
        {

        }

    }
}