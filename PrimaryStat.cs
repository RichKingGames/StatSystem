using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RichKingGames.StatSystem
{ 
    public class PrimaryStat : Stat
    {
        private int m_BaseValue;

        public override int baseValue => m_BaseValue;
        public PrimaryStat(StatDefinition definition) : base(definition)
        {

        }

        internal void Add(int amount)
        {
            m_BaseValue += amount;
            CalculateValue();
        }
        internal void Subtract(int amount)
        {
            m_BaseValue -= amount;
            CalculateValue();
        }
    }
}