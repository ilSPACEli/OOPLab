using MagicWorld.Repositories;
using MagicWorld.Services.Interfaces;
using MagicWorld.Services;
using MagicWorld;
using System;
using System.Security.Authentication;

internal class Program
{
    private static void Main(string[] args)
    {
        HogwartsDbContext context = new HogwartsDbContext();

        WizardRepository wizardRepo = new WizardRepository(context);
        DuelRepository duelRepo = new DuelRepository(context);

        IDuelService duelService = new DuelService(wizardRepo, duelRepo);

        Console.WriteLine("Welcome to the Dueling Club!");

        Console.WriteLine("\n--- Starting Training Duel ---");
        duelService.RunDuel(1, 2, MagicWorld.DuelType.Training);

        Console.WriteLine("\n--- Starting Ranked Duel ---");
        duelService.RunDuel(1, 2, MagicWorld.DuelType.Ranked);

        duelService.PrintHistory();

        Console.ReadKey();
    }
}