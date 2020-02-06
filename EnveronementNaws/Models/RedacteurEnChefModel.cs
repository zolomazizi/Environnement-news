using EnveronementNaws.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnveronementNaws.Models
{
    public class RedacteurEnChefModel
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
        public List<Article> articles { get; set; }
    }
}