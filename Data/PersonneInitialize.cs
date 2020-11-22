using ProjetWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetWeb.Data
{
    public class PersonneInitialize
    {
     
            public static void Initialize(BddContext context)
            {
                context.Database.EnsureCreated();

                // Look for any students.
                if (context.Personnes.Any())
                {
                    return;   // DB has been seeded
                }
            DateTime date = DateTime.Now;
            var personnes = new Personne[]
            {
                  
                    new Personne { Id = 1, Prenom = "Pierre", nom = "Marc", date_naissance =date , note = "a faire", departement = "etude", telephone = "02457262" },
                };
                foreach (Personne s in personnes)
                {
                    context.Personnes.Add(s);
                }
                context.SaveChanges();


            }

        }
    }


