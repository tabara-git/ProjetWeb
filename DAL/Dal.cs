using ProjetWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetWeb.DAL
{
    public class Dal : IDal
    {
        private BddContext _bdd;

        public Dal(BddContext bdd)
        {
            _bdd = bdd;
          _bdd.Database.EnsureCreated(); 
        }

        public List<Personne> ObtientTousLesPersonne()
        {
            return _bdd.Personnes.ToList();
        }
        public void CreerPersonne(Personne personne)
        {
            _bdd.Personnes.Add(new Personne { Prenom = personne.Prenom, nom = personne.nom , telephone = personne.telephone, mail =personne.mail , note =personne.note , date_naissance =personne.date_naissance  , departement=personne.departement    });
            _bdd.SaveChanges();
        }
       

      
        public void ModifierPersonne(Personne personne)
        {
            Personne PersonneTrouve = _bdd.Personnes.FirstOrDefault(personne => personne.Id == personne.Id);
            if (PersonneTrouve != null)
            {
                PersonneTrouve.nom = personne.nom;
                PersonneTrouve.Prenom = personne.Prenom;
                PersonneTrouve.telephone = personne.telephone;
                PersonneTrouve.mail = personne.mail;
                PersonneTrouve.note = personne.note;
                PersonneTrouve.departement = personne.departement;
                PersonneTrouve.date_naissance = personne.date_naissance;

                _bdd.SaveChanges();
            }
        }
        public void Dispose()
        {
            _bdd.Dispose();
        }
    }
}
