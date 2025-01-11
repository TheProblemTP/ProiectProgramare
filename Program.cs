using System;
using System.Collections.Generic;
using System.Linq;

namespace Proiect;

class Program
{
    static void Main(string[] args)
    {
        var aplicatie = new ManagementLocuinte();
        bool x = true;
        
        Locuinta locuinta1 = new Locuinta(423423, "Tulpina", 233, TipLocuinta.Apartament);
        LocuntiaInchiriata LocuntiaInchiriata = new LocuntiaInchiriata("Robi", "314245455", 200,100,new DateTime(2004/11/01), new DateTime(2004/11/09),locuinta1);
        
        while (x)
        {
            Console.WriteLine("1. Adaugă locuință");
            Console.WriteLine("2. Adauga locuinta inchiriata dupa id");
            Console.WriteLine("3. Vizualizeaza locuinte detinute");
            Console.WriteLine("4. Vizualizează locuințe închiriate");
            Console.WriteLine("5. Afisare venituri");
            Console.Writeline("6. Afisare rapoarte");
            Console.Writeline("7. Iesire");
            Console.Write("Alege opțiunea: ");
            int optiune = int.Parse(Console.ReadLine());

            switch (optiune)
            {
                case 1:
                   aplicatie.AdaugaLocuinte(new Locuinta(3,"daff", 32,TipLocuinta.Apartament));
                   Console.WriteLine("Locuinta Adaugata");
                    break;
                case 2:
                    Console.WriteLine("Scrie id-ul locuintei care vrei sa fie inchiriata");
                    int identificator = int.Parse(Console.ReadLine());
                    Locuinta locuinta = aplicatie.GetLocuinta(identificator);

                    if (locuinta != null)
                        LocuntiaInchiriata.AdaugaLocuinteInchiriate(new LocuntiaInchiriata("Robi", "314245455", 200,100,new DateTime(2004/11/01), new DateTime(2004/11/09),locuinta));
                    else 
                        Console.WriteLine("Locuinta nu exista");
                    Console.WriteLine("Locuinta Adaugata");
                    break;
                case 3:
                    aplicatie.AfisareLocuinte();
                    break;
                case 4:
                    LocuntiaInchiriata.AfisareLocuinteInchiriate();
                    break;
                case 5:
                    LocuntiaInchiriata.Venituri(new DateTime(2004/11/01), new DateTime(2004/11/09));
                    break;
                case 6:
                    LocuntiaInchiriata.Rapoarte();
                    break;
                case 7:
                    x=false;
                    break;
                default:
                    x = false;
                    break;
            }
        }
    }
}
