using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection.Metadata;
using System.Text.Json;

namespace Proiect;

class Program
{
    static void Main(string[] args)
    {
        var aplicatie = new ManagementLocuinte();
        bool x = true;
        JsonSerializerOptions options = new JsonSerializerOptions { IncludeFields = true };
        /*
    
        
        string locuinta1Str = JsonSerializer.Serialize(Aplicatie.locuinte, options);
        using (StreamWriter outputFile = new StreamWriter( "Adauga.txt"))
        {
          
                outputFile.WriteLine(locuinta1Str);
        }
*/
        try
        {
            string o = File.ReadAllText("Adauga.txt");
            Aplicatie.locuinte = JsonSerializer.Deserialize<List<Locuinta>?>(o, options);

        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
while (x)
{

    Console.WriteLine("1. Adaugă locuință");
    Console.WriteLine("2. Adauga locuinta inchiriata dupa id");
    Console.WriteLine("3. Vizualizeaza locuinte detinute");
    Console.WriteLine("4. Vizualizează locuințe închiriate");
    Console.WriteLine("5. Afisare Venituri");
    Console.WriteLine("6. Afisare rapoarte ");
    Console.WriteLine("7. Salveaza in fisier");
    Console.WriteLine("8.Editeaza o locuinta");
    Console.WriteLine("8. Ieșire");
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
        case 5: LocuntiaInchiriata.Venituri(new DateTime(2004/11/01), new DateTime(2004/11/09));
            break;
        case 6:  LocuntiaInchiriata.Rapoarte();
            break;

        case 7:
            string locuinta1Str = JsonSerializer.Serialize(Aplicatie.locuinte, options);
            using (StreamWriter outputFile = new StreamWriter( "Adauga.txt"))
            {
          
                outputFile.WriteLine(locuinta1Str);
            }
            
            Console.WriteLine("S-a salvat in fisier");
            
            break;
        case 8: Console.WriteLine("Ce locuinta vrei sa editezi: ");
            int i = 1;
            foreach (var locuintaa in Aplicatie.locuinte)
            {
                Console.WriteLine(i + " " + locuintaa);
                i++;
            }
            Console.Write("Alege Inca o optiune: ");
            int o2 = int.Parse(Console.ReadLine());
         
            if(o2-1 < 0 || o2-1 >= Aplicatie.locuinte.Count)
                Console.WriteLine("Locuinta invalida");
            else
            {
                Locuinta locselect = Aplicatie.locuinte[o2-1];
                Console.WriteLine("Ce vrei sa editezi: ");
                Console.WriteLine("1. Editeaza Adresa");
                Console.WriteLine("2. Editeaza Suprafata utila");
                Console.WriteLine("3. Editeaza Tip ");
                Console.Write("Alege Inca o optiune: ");
                int o3 = int.Parse(Console.ReadLine());

                switch (o3)
                {
                    case 1:
                        string a = Console.ReadLine();
                        locselect._Adresa = a;
                        break;
                    case 2:
                       int s = int.Parse(Console.ReadLine());
                        locselect._SuprafataUtila = s;
                        break;
                    case 3:
                        Console.WriteLine("Alege Tipul: ");
                        Console.WriteLine("1. Apartament ");
                        Console.WriteLine("2. Casa ");
                        Console.Write("Alege tipul dorit: ");
                       int o4 = int.Parse(Console.ReadLine());
                        switch (o4)
                        {
                            case 1:
                                locselect._Tip = TipLocuinta.Apartament;
                                break;
                            case 2:
                                locselect._Tip = TipLocuinta.Casa;
                                break;
                            default: Console.WriteLine("Tip invalid");
                                break;
                        }
                        break;
                    default: Console.WriteLine(" Optiune invalida");
                        break;
                        

                }

                
            }
          
            
            
            
            break;
        default:
            Console.WriteLine("Comanda invalida");
            break;
    }
}
}
}
