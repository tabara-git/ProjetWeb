using ProjetWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetWeb.DAL
{
    public interface IDal : IDisposable
    {
        List<Personne> ObtientTousLesPersonne();
        public void ModifierPersonne(Personne personne);
        void CreerPersonne(Personne personne);
    }
}
