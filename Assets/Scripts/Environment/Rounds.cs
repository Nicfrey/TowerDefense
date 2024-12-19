using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

namespace Environment
{
    [CreateAssetMenu(menuName = "Game/Round", fileName = "RoundSO", order = 0)]
    public class Rounds : ScriptableObject
    {
        public List<Round> roundsLevel;
    }

    [Serializable]
    public class Round
    {
        [field: SerializeField] public int[] NumberByTypeOfEnemies { get; private set; }
        [field: SerializeField] public GameObject[] TypeEnemies { get; private set; }
        public int RemainingEnemies => NumberByTypeOfEnemies.Sum();
    }
}
