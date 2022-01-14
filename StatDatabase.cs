using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RichKingGames.StatSystem
{
    [CreateAssetMenu(fileName = "StatDatabase", menuName = "StatSystem/StatDatabase")]
    public class StatDatabase : ScriptableObject
    {
        public List<StatDefinition> stats;
        public List<StatDefinition> attributes;
        public List<StatDefinition> primaryStats;
    }
}