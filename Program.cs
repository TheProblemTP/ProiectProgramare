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
        while (x)
        {
            Console.WriteLine("1. Adaugă locuință");
            Console.WriteLine("2. ");
            Console.WriteLine("3. Vizualizeaza locuinte detinute");
            Console.WriteLine("4. Vizualizează locuințe închiriate");
            Console.WriteLine("5. Ieșire");
            Console.Write("Alege opțiunea: ");
            int optiune = int.Parse(Console.ReadLine());

            switch (optiune)
            {
                case 1:
                   aplicatie.AdaugaLocuinte(new Locuinta(3,"daff", 32,TipLocuinta.Apartament));
                   Console.WriteLine("Locuinta Adaugata");
                    break;
                case 2:
                    Locuinta locuinta = aplicatie.GetLocuinta(3);
                    
                    if (locuinta != null) 
                        LocuntiaInchiriata.AdaugaLocuinteInchiriate(new LocuntiaInchiriata(34,"dsff", 435, TipLocuinta.Casa,"Robert","5030201234355",200,50,new DateTime(2004/09/14), new DateTime(1900,04,02)),locuinta);
                    else 
                        Console.WriteLine("Locuinta nu exista");
                    Console.WriteLine("Locuinta Adaugata");
                    break;
                case 3:
                    aplicatie.AfisareLocuinte();
                    break;
                case 4:
                    aplicatie.AfisareLocuinteInchiriate();
                    break;
                case 5:
                    x = false;
                    break;
                default:
                    x = false;
                    break;
            }
        }
    }
}
