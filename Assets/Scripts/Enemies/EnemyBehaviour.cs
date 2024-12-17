using System;
using Environment;
using UnityEngine;
using UnityEngine.AI;

namespace Enemies
{
    public class EnemyBehaviour : MonoBehaviour
    {
        [SerializeField] private float speed;
        private NavMeshAgent _agent;
        private HealthBehaviour _health;

        private void Start()
        {
            _agent = GetComponent<NavMeshAgent>();
            _health = GetComponent<HealthBehaviour>();
            _agent.speed = speed;
            _agent.SetDestination(EndGoalBehaviour.Instance.EndGoalPosition);
        }

        public void Kill()
        {
            _health.Kill();
        }
    }
}
