using System;
using System.Collections.Generic;
namespace Proiect;

public abstract class Aplicatie 
{
    public static List<Locuinta> locuinte = new List<Locuinta>();
    
    
    public abstract void AdaugaLocuinte(Locuinta locuinta); 
    

    public  abstract void AfisareLocuinte();
    
} 