using System;
using System.Collections.Generic;
using System.Linq;
namespace Proiect;

public class LocuntiaInchiriata
{
    public static List<LocuntiaInchiriata> locuinteInchiriate = new List<LocuntiaInchiriata>();
   internal string _NumeChirias;
   internal string _CNPChririas;
   internal double _ChiriePeLuna;
   internal double _Garantie;
   public Locuinta _locuinta;
    public DateTime DataInceput {get;}
    public DateTime DataSfarsit {get;}

    public LocuntiaInchiriata(int id, string adresa, double SuprafataUtila, TipLocuinta tip, string numeChirias, string cnpChirias, double chiriePeLuna, double garantie, DateTime dataInceput, DateTime dataSfart, Locuinta locuinta ) 
    {
       _NumeChirias = numeChirias;
       _CNPChririas=  cnpChirias;
       _ChiriePeLuna = chiriePeLuna;
       _Garantie= garantie;
       DataInceput = dataInceput;
       DataSfarsit = dataSfart;
       _locuinta = locuinta;
    }
    
    
    public static void AdaugaLocuinteInchiriate(LocuntiaInchiriata  locuinta)
    {
        foreach (var locuintaInchiriata in locuinteInchiriate)
        {
            // un if ca locuinta pe care vreau sa o inchiriez nu este deja inchiriata pe perioada specficata
            if (locuintaInchiriata._locuinta == locuinta._locuinta)
                if (locuintaInchiriata.DataInceput < locuinta.DataInceput)
                {
                    Console.WriteLine("Locuinta deja inchiriata");
                    return; 
                }
        }
        locuinteInchiriate.Add(locuinta);
    }

    public  static void AfisareLocuinteInchiriate()
    {
        foreach (var locuinta in locuinteInchiriate)
        {
            Console.WriteLine(
                " Nume Chirias este {4}, Cnp e {5}, Chirie pe luna e {6} si Garantia e {7}", 
                 locuinta._NumeChirias,locuinta._CNPChririas,locuinta._ChiriePeLuna,locuinta._Garantie);
        }
       
    }
    
    
   public Locuinta GetLocuinta(int id)
    {
        foreach (var locuinta in locuinte)
        {
            if(locuinta._Id == id)
                return locuinta;
        }

        return null;
    }
    Console.WriteLine(" Nume Chirias este {4}, Cnp e {5}, Chirie pe luna e {6} si Garantia e {7}",locuinta._NumeChirias,locuinta._CNPChririas,locuinta._ChiriePeLuna,locuinta._Garantie);
    
    

    public void Rapoarte()
    {
        int inchiriate = 0, disponibile = 0, total=0, nrInchirieri=0;
        double sumaDuratelor=0, durataMedie=0;
        double pret;
        pret = _ChiriePeLuna / _locuinta._SuprafataUtila;
        Console.WriteLine("Pretul pe suprafata utila este : {0}", pret);

        foreach (var locuinta in locuinteInchiriate)
        {
                inchiriate = inchiriate + 1;
        }

        foreach (var locuinta in ManagementLocuinte.locuinte)
        {
            total = total + 1;
        }

        disponibile = total - inchiriate;
        
        Console.WriteLine("Procentul locuintelor ocupate este {0}, iar cele disponibile este {1}", (inchiriate*100)/total, (disponibile*100)/total);
        var loc = locuinteInchiriate;

        foreach (var locuinta in locuinteInchiriate)
        {
            double durata = (locuinta.DataSfarsit - locuinta.DataInceput).TotalDays; 
            
            sumaDuratelor = sumaDuratelor + durata;
            nrInchirieri++;
        }

        durataMedie = sumaDuratelor / nrInchirieri;
        
        Console.WriteLine("Durata medie a inchirierilor este : {0}", durataMedie);
    }

    public void Venituri(DateTime DataStart, DateTime DataEnd)
    {
        double Durata=0, ChiriePeZi = _ChiriePeLuna / 30, Suma=0;

        foreach (var locuinta in locuinteInchiriate)
        {
            if (locuinta.DataInceput >= DataStart && locuinta.DataSfarsit >= DataEnd)
            {
                Durata = (locuinta.DataSfarsit - locuinta.DataInceput).TotalDays;
                Suma = Suma + Durata * ChiriePeZi;
            }
        }
        
        Console.WriteLine("Veniturile realizate in perioada determinata sunt : {0}", Suma);
    }
    
    
}
