using System;
using System.Collections.Generic;
namespace Proiect;

public abstract class Aplicatie 
{
    protected static List<Locuinta> locuinte = new List<Locuinta>();
 public static List<LocuntiaInchiriata> locuinteInchiriate = new List<LocuntiaInchiriata>();
    private List<Sesizare> sesizari = new List<Sesizare>();
    
    public abstract void AdaugaLocuinte(Locuinta locuinta); 
    public abstract  void AdaugaLocuinteInchiriate(LocuntiaInchiriata locuinta);

    public  abstract void AfisareLocuinte();

    public abstract  void AfisareLocuinteInchiriate();
} 