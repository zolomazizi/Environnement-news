using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnveronementNaws.Models
{
    public class CommentaireModel
    {
        public int ID { get; set; }
        public Nullable<int> ArticleID { get; set; }
        public string Contenu { get; set; }
        public string User_mail { get; set; }
        public string User_name { get; set; }
        public Nullable<System.DateTime> CommentaireDate { get; set; }
    }
}