using System;
using System.Collections.Generic;
using System.Linq;
namespace Proiect;

public class LocuntiaInchiriata : Locuinta
{
   
   internal string _NumeChirias;
   internal string _CNPChririas;
   internal double _ChiriePeLuna;
   internal double _Garantie;
    public DateTime DataInceput {get;set;}
    public DateTime DataSfarsit {get;set;}

    public LocuntiaInchiriata(int id, string adresa, double SuprafataUtila, TipLocuinta tip, string numeChirias, string cnpChirias, double chiriePeLuna, double garantie, DateTime dataInceput, DateTime dataSfart ) 
        : base( id, adresa, SuprafataUtila,  tip)
    {
       _NumeChirias = numeChirias;
       _CNPChririas=  cnpChirias;
       _ChiriePeLuna = chiriePeLuna;
       _Garantie= garantie;
       DataInceput = dataInceput;
       DataSfarsit = dataSfart;
    }
    
    
    
    

    public void Rapoarte()
    {
        int inchiriate = 0, disponibile = 0, total=0, nrInchirieri=0;
        double sumaDuratelor=0, durataMedie=0;
        double pret;
        pret = _ChiriePeLuna / _SuprafataUtila;
        Console.WriteLine("Pretul pe suprafata utila este : {0}", pret);

        foreach (var locuinta in locuinteInchiriate)
        {
                inchiriate = inchiriate + 1;
        }

        foreach (var locuinta in locuinte)
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