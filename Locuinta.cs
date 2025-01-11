using System;
using System.Collections.Generic;
namespace Proiect;
public enum TipLocuinta {Apartament, Casa}
public class Locuinta
{
    internal int _Id;
    internal string _Adresa;
    internal double _SuprafataUtila;
   internal TipLocuinta _Tip;

    public Locuinta(int id, string adresa, double SuprafataUtila, TipLocuinta tip)
    {
        _Id = id;
        _Adresa = adresa;
        _SuprafataUtila = SuprafataUtila;
        _Tip = tip;
    }      
 }
