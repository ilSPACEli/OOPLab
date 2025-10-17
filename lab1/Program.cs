using MagicWorld;

internal class Program
{
    private static void Main(string[] args)
    {

        Wizard gerald = new Wizard("Gerald", "Wolf School");
        Wizard eredin = new Wizard("Eredin", "Wild Hunt");

        gerald.LearnSpell(new Spell("Aard", 5));             
        gerald.LearnSpell(new Spell("Axii", 15));            
        gerald.LearnSpell(new Spell("Yrden", 20));           
        gerald.LearnSpell(new Spell("Igni", 13));            
        gerald.LearnSpell(new Spell("Quen", 14));            
        gerald.LearnSpell(new Spell("Moon Dust", 9));        
        gerald.LearnSpell(new Spell("Dimeritium Bomb", 10)); 
        gerald.LearnSpell(new Spell("Dragon's Dream", 13));  
        gerald.LearnSpell(new Spell("Northern Wind", 10));   
        //gerald.LearnSpell(new Spell("Ritual of Death", 101));

        eredin.LearnSpell(new Spell("Aard", 5));
        eredin.LearnSpell(new Spell("Axii", 15));
        eredin.LearnSpell(new Spell("Yrden", 20));
        eredin.LearnSpell(new Spell("Igni", 13));
        eredin.LearnSpell(new Spell("Quen", 14));
        eredin.LearnSpell(new Spell("Moon Dust", 9));
        eredin.LearnSpell(new Spell("Dimeritium Bomb", 10));
        eredin.LearnSpell(new Spell("Dragon's Dream", 13));
        eredin.LearnSpell(new Spell("Northern Wind", 10));
        //eredin.LearnSpell(new Spell("Ritual of Death", 101));


        DuelingClub duelingClub = new DuelingClub();
        duelingClub.HostDuel(gerald, eredin);

        foreach (DuelResult duelResult in gerald.DuelsHistory) {
            Console.WriteLine();
            foreach (string log in duelResult.TurnsLog)
                Console.WriteLine(" - " + log);
            Console.WriteLine((duelResult.Winner != null ? duelResult.Winner.Name + "`s victory!" : "a draw!"));
            Console.WriteLine("Duel between " + duelResult.Contestants[0].Name + " and " + duelResult.Contestants[1].Name + " was resulted in a " + (duelResult.Winner != null ? duelResult.Winner.Name + "`s victory!" : "a draw!"));
        }
    }
}