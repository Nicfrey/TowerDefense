using System;
using Environment;
using UnityEngine;
using UnityEngine.AI;

namespace Enemies
{
    public class EnemyBehaviour : MonoBehaviour
    {
        private NavMeshAgent _agent;
        private HealthBehaviour _health;

        private void Start()
        {
            _agent = GetComponent<NavMeshAgent>();
            _health = GetComponent<HealthBehaviour>();
            _agent.SetDestination(EndGoalBehaviour.Instance.EndGoalPosition);
        }

        public void Kill()
        {
            _health.Kill();
        }
    }
}
