using System;
using System.Collections;
using System.Collections.Generic;
using Environment;
using UnityEngine;
using UnityEngine.AI;

namespace Enemies
{
    public enum EnemyType
    {
        Normal,
        Tiny
    }
    public class EnemyBehaviour : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private EnemyType enemyType;
        private NavMeshAgent _agent;
        private HealthBehaviour _health;

        private Coroutine _slowRoutine;
        public EnemyType EnemyType => enemyType;

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

        public void Slow(float amountSlow, float duration)
        {
            if (_slowRoutine != null)
            {
                StopCoroutine(_slowRoutine);
            }
            _slowRoutine = StartCoroutine(SlowRoutine(amountSlow, duration));
        }

        private IEnumerator SlowRoutine(float amountSlow, float duration)
        {
            _agent.speed = speed - amountSlow;
            yield return new WaitForSeconds(duration);
            _agent.speed = speed;
        }
    }
}
