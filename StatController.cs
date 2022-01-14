using System;
using System.Collections.Generic;
using UnityEngine;

namespace RichKingGames.StatSystem
{
    public class StatController : MonoBehaviour
    {
        [SerializeField] private StatDatabase m_StatDatabase;
        protected Dictionary<string, Stat> m_Stats = new Dictionary<string, Stat>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, Stat> stats => m_Stats;

        private bool m_IsInitialized;
        public bool isInitializes => m_IsInitialized;
        public event Action initialized;
        public event Action willUninitialized;

        protected virtual void Awake()
        {
            if(!m_IsInitialized)
            {
                Initialize();
                m_IsInitialized = true;
                initialized?.Invoke();
            }
        }

        private void Initialize()
        {
            foreach(StatDefinition definition in m_StatDatabase.stats)
            {
                m_Stats.Add(definition.name, new Stat(definition));
            }

            foreach (StatDefinition definition in m_StatDatabase.attributes)
            {
                m_Stats.Add(definition.name, new Attribute(definition));
            }

            foreach(StatDefinition definition in m_StatDatabase.primaryStats)
            {
                m_Stats.Add(definition.name, new PrimaryStat(definition));
            }
        }

        private void OnDestroy()
        {
            willUninitialized?.Invoke();
        }
    }
}