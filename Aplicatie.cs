using System;
using System.Collections.Generic;
namespace Proiect;

public abstract class Aplicatie 
{
    public static List<Locuinta> locuinte = new List<Locuinta>();
 
    private List<Sesizare> sesizari = new List<Sesizare>();
    
    public abstract void AdaugaLocuinte(Locuinta locuinta); 
    

    public  abstract void AfisareLocuinte();
    
} 