namespace Proiect;

public class ManagementLocuinte : Aplicatie
{
    public override void AdaugaLocuinte(Locuinta locuinta)
    {
        
        locuinte.Add(locuinta);
    }

    

    public override void AfisareLocuinte()
    {
        foreach (var locuinta in locuinte)
        {
            Console.WriteLine(
                "Id-ul locuintei este {0}, Adresa locuintei e {1}, Suprafata Utila este {2}, Tipul este {3}",
                locuinta._Id, locuinta._Adresa, locuinta._SuprafataUtila, locuinta._Tip);
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

   
    
}