using System;
using Object = UnityEngine.Object;

namespace RichKingGames.StatSystem
{
    public enum ModifierOperationType
    {
        Additive,
        Multiplicative,
        Override
    }
    public class StatModifier
    {
        public Object source { get; set; }
        public int magnitude { get; set; }
        public ModifierOperationType type { get; set; }
    }
   
}