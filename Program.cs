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
    Console.WriteLine("7. Salveaza in fisier locuinte detinute");
    Console.WriteLine("8. Salveaza in fisier locuinte inchiriate");
    Console.WriteLine("9.Editeaza o locuinta detinuta");
    Console.WriteLine("10.Editeaza o locuinta inchiriata");
    Console.WriteLine("11. Iesire");
    Console.Write("Alege opțiunea: ");
    int optiune = int.Parse(Console.ReadLine());
    switch (optiune)
    {
        case 1:
            Console.Write("Scrie id-ul: ");
           int id = int.Parse(Console.ReadLine());
            Console.Write("Scrie Adresa:  ");
            string adres = Console.ReadLine();
            Console.Write("Scrie Suprafata:  ");
            int suprafata = int.Parse(Console.ReadLine());
            
            
            TipLocuinta? locui=null;
            Console.WriteLine("Alege Tipul: ");
            Console.WriteLine("1. Apartament ");
            Console.WriteLine("2. Casa ");
            Console.Write("Alege tipul dorit: ");
            int o5 = int.Parse(Console.ReadLine());
            switch (o5)
            {
                case 1:
                    locui = TipLocuinta.Apartament;
                    break;
                case 2:
                   locui = TipLocuinta.Casa;
                    break;
                default: Console.WriteLine("Tip invalid nu s-a creeat locuinta");
                    break;
            }

            if (locui != null)
            {
                aplicatie.AdaugaLocuinte(new Locuinta(id, adres, suprafata,locui));
                Console.WriteLine("Locuinta Adaugata");
            }
            break;
        case 2:
            Console.WriteLine("Scrie id-ul locuintei care vrei sa fie inchiriata");
            int identificator = int.Parse(Console.ReadLine());
            Locuinta locuinta = aplicatie.GetLocuinta(identificator);

            if (locuinta != null)
            {
                Console.Write("Scrie numele chiriasului: ");
                string numeChirias = Console.ReadLine();
                Console.Write("Scrie cnp chiriasului: ");
                string cnpChirias = Console.ReadLine();
                Console.Write("Scrie chiria pe luna a chiriasului: ");
                int chiriepeluna = int.Parse(Console.ReadLine());
                Console.Write("Scrie garantia chiriasului: ");
                int garantie = int.Parse(Console.ReadLine());
                Console.Write("Scrie Ziua din data in care incepe inchirierea:  ");
                int d1 = int.Parse(Console.ReadLine());
                Console.Write("Scrie luna din data in care incepe inchirierea:  ");
                int m1 = int.Parse(Console.ReadLine());
                Console.Write("Scrie anul din data in care incepe inchirierea:  ");
                int y1 = int.Parse(Console.ReadLine());
                Console.Write("Scrie Ziua din data in care se incheie inchirierea:  ");
                int d2 = int.Parse(Console.ReadLine());
                Console.Write("Scrie luna din data  in care se incheie inchirierea:  ");
                int m2 = int.Parse(Console.ReadLine());
                Console.Write("Scrie anul din data  in care se incheie inchirierea:  ");
                int y2 = int.Parse(Console.ReadLine());
                
                LocuntiaInchiriata.AdaugaLocuinteInchiriate(new LocuntiaInchiriata("Robi", "314245455", 200, 100,
                    new DateTime(y1 / m1 / d1), new DateTime(y2 / m2 / d2), locuinta));
            }
            else
                Console.WriteLine("Locuinta nu exista");
            Console.WriteLine("Locuinta Inchiriata Adaugata");
            break;
        case 3:
            aplicatie.AfisareLocuinte();
            break;
        case 4:
            LocuntiaInchiriata.AfisareLocuinteInchiriate();
            break;
        case 5:
            Console.Write("Scrie Ziua din data in care vrei sa inceapa veniturile:  ");
            int d3 = int.Parse(Console.ReadLine());
            Console.Write("Scrie luna din data in care vrei sa inceapa veniturile:  ");
            int m3 = int.Parse(Console.ReadLine());
            Console.Write("Scrie anul din data in care vrei sa inceapa veniturile:   ");
            int y3 = int.Parse(Console.ReadLine());
            Console.Write("Scrie Ziua din data in care se incheie veniturile:  ");
            int d4 = int.Parse(Console.ReadLine());
            Console.Write("Scrie luna din data  in care se incheie veniturile:  ");
            int m4 = int.Parse(Console.ReadLine());
            Console.Write("Scrie anul din data  in care se incheie veniturile:  ");
            int y4 = int.Parse(Console.ReadLine());
            
            LocuntiaInchiriata.Venituri(new DateTime(y3/m3/d3), new DateTime(y4/m4/d4));
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
        
        case 8:
            string locuintainchiriataStr = JsonSerializer.Serialize(LocuntiaInchiriata.locuinteInchiriate, options);
            using (StreamWriter outputFile = new StreamWriter( "AdaugaLocInchiriate.txt"))
            {
          
                outputFile.WriteLine(locuintainchiriataStr);
            }
            
            Console.WriteLine("S-a salvat in fisier");
            
            break;
        
        case 9: Console.WriteLine("Ce locuinta vrei sa editezi: ");
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
        
        case 10: 
            
                Console.WriteLine("Ce locuinta inchiriata vrei sa editezi: ");
            int j = 1;
            foreach (var locuintaaei in LocuntiaInchiriata.locuinteInchiriate)
            {
                Console.WriteLine(j + " " + locuintaaei);
                j++;
            }
            Console.Write("Alege Inca o optiune: ");
            int o8 = int.Parse(Console.ReadLine());
         
            if(o8-1 < 0 || o8-1 >=LocuntiaInchiriata.locuinteInchiriate.Count)
                Console.WriteLine("Locuinta invalida");
            else
            {
                LocuntiaInchiriata locuintaselect = LocuntiaInchiriata.locuinteInchiriate[o8 - 1];
                Console.WriteLine("Ce vrei sa editezi: ");
                Console.WriteLine("1. Editeaza Numele Chiriasului");
                Console.WriteLine("2. Editeaza Cnpul Chiriasului");
                Console.WriteLine("3. Editeaza Chiria Pe Luna ");
                Console.WriteLine("4. Editeaza Garantia ");
                Console.WriteLine("5. Editeaza Data Start de inchiriere ");
                Console.WriteLine("6. Editeaza Data de sfarsit pentru inchiriere ");
                Console.Write("Alege Inca o optiune: ");
                int o10 = int.Parse(Console.ReadLine());

                switch (o10)
                {
                    case 1:
                        string Jedi = Console.ReadLine();
                        locuintaselect._NumeChirias = Jedi;
                        break;
                    case 2:
                        string Vincent = Console.ReadLine();
                        locuintaselect._CNPChririas = Vincent;
                        break;
                    case 3:
                        int Chiriepeluna = int.Parse(Console.ReadLine());
                        locuintaselect._ChiriePeLuna = Chiriepeluna;
                        break;
                    case 4:
                        int Garantie = int.Parse(Console.ReadLine());
                        locuintaselect._Garantie = Garantie;
                        break;
                    case 5:
                        Console.WriteLine("Scrie ziua datii de inceput pe care vrei sa o pui: ");
                        int d6 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Scrie luna datii de inceput pe care vrei sa o pui: ");
                        int m6 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Scrie anul datii de inceput pe care vrei sa o pui: ");
                        int y6 = int.Parse(Console.ReadLine());
                        locuintaselect.DataInceput=new DateTime(y6/m6/d6);
                        break;
                    
                    case 6:
                        Console.WriteLine("Scrie ziua datii de inceput pe care vrei sa o pui: ");
                        int d7 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Scrie luna datii de inceput pe care vrei sa o pui: ");
                        int m7 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Scrie anul datii de inceput pe care vrei sa o pui: ");
                        int y7 = int.Parse(Console.ReadLine());
                        locuintaselect.DataSfarsit=new DateTime(y7/m7/d7);
                        break;
                }
            }

            break;
        case 11: x = false;
            break;
            
        default:
            Console.WriteLine("Comanda invalida");
            break;
    }
}
}
}
