using Heron_Cendre.Models;
using Heron_Cendre.Data.Enum;

namespace Heron_Cendre.Data
{
    public class AppDbInitialize
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //Ajouter Chambre
                if(context.chambres.Any())
                {
                    context.chambres.AddRange(new List<Chambre>()
                    {
                        new Chambre()
                        {
                            NumChambre = "ch1",
                            Image = "https://th.bing.com/th/id/R.f5736b07a5a11bb82de91ce4b37c752f?rik=MGKB6yWLT5Ietg&pid=ImgRaw&r=0",
                            Prix = 25000,
                            Description= "Chambre de luxe"
                        },
                        new Chambre()
                        {
                            NumChambre = "ch2",
                            Image = "https://th.bing.com/th/id/R.f5736b07a5a11bb82de91ce4b37c752f?rik=MGKB6yWLT5Ietg&pid=ImgRaw&r=0",
                            Prix = 25000,
                            Description= "Chambre de luxe"
                        }
                    });
                    context.SaveChanges();
                }
                //Ajouter Client
                if(context.clients.Any())
                {
                    context.clients.AddRange(new List<Client>()
                    {
                        new Client()
                        {
                            Nom = "Nzomo",
                            Prenom = "Rabier",
                            Adresse = "Logbessou",
                            Telephone = 692248460,
                            Email = "fokourabier@gmail.com",
                            DateNaissance = DateTime.Now,
                            MotPasse = "7christian7",
                            NCompte = 2
                        },
                        new Client()
                        {
                            Nom = "Fokou",
                            Prenom = "Christian",
                            Adresse = "Logbessou",
                            Telephone = 692248460,
                            Email = "fokourabier@gmail.com",
                            DateNaissance = DateTime.Now,
                            MotPasse = "7christian7",
                            NCompte = 3
                        }
                    });
                    context.SaveChanges();
                }
                //Ajouter Menu
                if (context.menu.Any())
                {
                    context.menu.AddRange(new List<Menu>
                    {
                        new Menu()
                        {
                            Nom_Repas = "Riz sauce tomate",
                            Image_Repas = "https://jesuisuncuisinier.fr/wp-content/uploads/2017/10/riz-sauce-tomate-et-oeuf-au-plat.jpg",
                            Prix = 1000
                        },
                        new Menu()
                        {
                            Nom_Repas = "Riz sauce tomate",
                            Image_Repas = "https://jesuisuncuisinier.fr/wp-content/uploads/2017/10/riz-sauce-tomate-et-oeuf-au-plat.jpg",
                            Prix = 1000
                        }
                    });
                    context.SaveChanges();
                }
                //Ajouter Prestation
                if(context.prestations.Any())
                {
                    context.prestations.AddRange(new List<Prestation>
                    {
                        new Prestation() 
                        {
                            Nom_Service = "Y",
                            Description = "H",
                            Date_Debut = DateTime.Now,
                            Date_Fin = DateTime.Now.AddDays(7),
                            reservationId = 1,
                            Prix = 1000
                        },
                        new Prestation()
                        {
                            Nom_Service = "i",
                            Description = "k",
                            Date_Debut = DateTime.Now,
                            Date_Fin = DateTime.Now.AddDays(7),
                            reservationId = 2,
                            Prix = 1000
                        }
                    });
                    context.SaveChanges();
                }
                //Ajouter Reservation
                if(context.reservation.Any())
                {
                    context.reservation.AddRange(new List<Reservation>
                    {
                        new Reservation()
                        {
                            Date_Debut = DateTime.Now,
                            Date_Fin = DateTime.Now.AddDays(7)
                            //client 
                        },
                        new Reservation()
                        {
                            Date_Debut = DateTime.Now,
                            Date_Fin = DateTime.Now.AddDays(7)
                            //client 
                        }
                    });
                }
            }
        }
    }
}
