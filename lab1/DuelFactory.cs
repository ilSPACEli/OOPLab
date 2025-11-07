using System;
using MagicWorld;

namespace MagicWorld
{
    public enum DuelType { 
        Training, 
        Ranked, 
        Base 
    }

    public class DuelFactory
    {
        public BaseDuel CreateDuel(DuelType type)
        {
            switch (type)
            {
                case DuelType.Training: return new TrainingDuel();
                case DuelType.Ranked: return new RankedDuel();
                default: throw new ArgumentException("Unknown duel type");
            }
        }
    }
}