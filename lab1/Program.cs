using System;
using System.Security.Authentication;
using MagicWorld;

internal class Program
{
    private static void Main(string[] args)
    {
        Wizard Gerald = new Witcher("Gerald", "Wolf School");
        Wizard Yennefer = new Sorceress("Yennefer", "Vengerberg Lodge");

        Gerald.LearnSpell(new Spell("Igni", 15, Effect.Damage));
        Gerald.LearnSpell(new Spell("Aard", 9, Effect.Stunning));
        Gerald.LearnSpell(new Spell("Dimeritium Bomb", 10));
        Gerald.LearnSpell(new Spell("Dragon's Dream", 13));
        Gerald.LearnSpell(new Spell("Northern Wind", 10));

        Yennefer.LearnSpell(new Spell("Thunderbolt", 15, Effect.Stunning));
        Yennefer.LearnSpell(new Spell("Fireball", 9, Effect.Damage));
        Yennefer.LearnSpell(new Spell("Dimeritium Bomb", 10));
        Yennefer.LearnSpell(new Spell("Dragon's Dream", 13));
        Yennefer.LearnSpell(new Spell("Northern Wind", 10));

        DuelingClub club = new DuelingClub();
        DuelFactory factory = new DuelFactory();

        club.HostDuel(Gerald, Yennefer, factory.CreateDuel(DuelType.Training));
        club.HostDuel(Gerald, Yennefer, factory.CreateDuel(DuelType.Ranked));

        Console.WriteLine($"{Gerald.Name}'s History:");
        foreach (var duel in Gerald.DuelsHistory)
        {
            Console.WriteLine($"- Vs {(duel.Contestants[0] == Gerald ? duel.Contestants[1].Name : duel.Contestants[0].Name)}: {duel.Winner?.Name ?? "Draw"}");
        }

        Console.WriteLine($"\n{Yennefer.Name}'s History:"); 
        foreach (var duel in Yennefer.DuelsHistory)
        {
            Console.WriteLine($"- Vs {(duel.Contestants[0] == Yennefer ? duel.Contestants[1].Name : duel.Contestants[0].Name)}: {duel.Winner?.Name ?? "Draw"}");
        }
    }
}