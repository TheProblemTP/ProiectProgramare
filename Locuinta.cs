using System;
using System.Collections.Generic;
namespace Proiect;
public enum TipLocuinta {Apartament, Casa}
public class Locuinta
{
    public int _Id;
    public string _Adresa;
    public double _SuprafataUtila;
    public TipLocuinta _Tip;

    /// sunt publice pentru a putea fi citite si suprascrise de catre calasa JsonSerializer

    public Locuinta()
    {
        
    }
    
    public Locuinta(int id, string adresa, double SuprafataUtila, TipLocuinta tip)
    {
        _Id = id;
        _Adresa = adresa;
        _SuprafataUtila = SuprafataUtila;
        _Tip = tip;
    }
       
}
    


