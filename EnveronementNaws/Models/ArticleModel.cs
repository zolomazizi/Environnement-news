using EnveronementNaws.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnveronementNews.Models
{
    public class ArticleModel
    {
        public int ID { get; set; }
        public string Date { get; set; }
        public string Titre { get; set; }
        public string Body { get; set; }
        public string Img { get; set; }
        public string Video { get; set; }
       

        public string Description { get; set; }
        // public List<Article> articles { get; set; }
    }
}