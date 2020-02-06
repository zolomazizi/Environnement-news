using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnveronementNaws.Models
{
    public class JournalistesModel
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        
        
        public string Image { get; set; }
        public Nullable<bool> Statu { get; set; }
        public string Email { get; set; }
        public int NombrArticle { get; set; }
    }
}