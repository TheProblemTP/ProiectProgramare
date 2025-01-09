using System;
using System.Collections.Generic;
namespace Proiect;
public enum TipLocuinta {Apartament, Casa}
public class Locuinta : Aplicatie
{
    internal int _Id;
    internal string _Adresa;
    internal double _SuprafataUtila;
   internal TipLocuinta _Tip;
   internal TipLocuinta _Tip2;

    public Locuinta(int id, string adresa, double SuprafataUtila, TipLocuinta tip)
    {
        _Id = id;
        _Adresa = adresa;
        _SuprafataUtila = SuprafataUtila;
        _Tip = tip;
    }

    public override void AdaugaLocuinte(Locuinta locuinta)
    {
        locuinte.Add(locuinta);
    }

    public override void AdaugaLocuinteInchiriate(LocuntiaInchiriata inchiriata)
    {
        locuinteInchiriate.Add(inchiriata);
    }
    
    public override void AfisareLocuinte()
    {
        foreach (var locuinta in locuinte)
        {
            Console.WriteLine(
                "Id-ul locuintei este {0}, Adresa locuintei e {1}, Suprafata Utila este {2}, Tipul este {3}" ,
                locuinta._Id, locuinta._Adresa, locuinta._SuprafataUtila, locuinta._Tip);
        }
    }
    
    public override void AfisareLocuinteInchiriate()
    {
        foreach (var locuinta in locuinteInchiriate)
        {
            Console.WriteLine(
                "Id-ul locuintei este {0}, Adresa locuintei e {1}, Suprafata Utila este {2}, Tipul este {3}, Nume Chirias este {4}, Cnp e {5}, Chirie pe luna e {6} si Garantia e {7}", 
                locuinta._Id, locuinta._Adresa, locuinta._SuprafataUtila, locuinta._Tip, locuinta._NumeChirias,locuinta._CNPChririas,locuinta._ChiriePeLuna,locuinta._Garantie);
        }
       
    }
    
}

