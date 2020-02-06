using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnveronementNews.Models
{
    public class ChefRedactionModel
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public bool Statu { get; set; }
        public string Image { get; set; }
        public string Tele { get; set; }
        public string User_id { get; set; }
        public int NombrArticle { get; set; }
    }
}