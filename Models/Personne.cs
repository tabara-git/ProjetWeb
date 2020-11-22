using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetWeb.Models
{
    public class Personne
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "le Prenom est obligatoire")]
        public string Prenom { get; set; }
        [Required(ErrorMessage = "le Nom est obligatoire")]
        public string nom { get; set; }
        [Required(ErrorMessage = "le numero telephone est obligatoire")]
        public string telephone { get; set; }
        [Required(ErrorMessage = "le mail est obligatoire")]
        public string mail { get; set; }
            public string note { get; set; }
            public string departement { get; set; }
            public DateTime date_naissance { get; set; }
        }
    }
