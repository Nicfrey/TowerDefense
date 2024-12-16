using System;
using Enemies;
using UnityEngine;

namespace Environment
{
    public class EndGoalBehaviour : MonoBehaviour
    {
        public static EndGoalBehaviour Instance;
        
        [SerializeField] private Transform endGoal;
        public Vector3 EndGoalPosition => endGoal.position;
        private HealthBehaviour _health;

        private void Awake()
        {
            if (!Instance)
            {
                Instance = this;
                return;
            }
            Destroy(gameObject);
        }

        private void Start()
        {
            _health = GetComponent<HealthBehaviour>();
        }

        private void OnDestroy()
        {
            if (Instance == this)
            {
                Instance = null;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            EnemyBehaviour enemy = other.GetComponent<EnemyBehaviour>();
            if (enemy)
            {
                _health.TakeDamage(1);
                enemy.Kill();
            }
        }
    }
}
