using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Environment
{
    public class StartPositionBehaviour : MonoBehaviour
    {
        public static StartPositionBehaviour Instance;
        [SerializeField] private Transform startPosition;
        private RoundManagerBehaviour roundManager;
        [SerializeField] private GameObject[] enemyPrefabs;
        private List<GameObject> _enemiesSpawned = new ();
        private bool _isDestroyingObject;

        private void Awake()
        {
            if (!Instance)
            {
                Instance = this;
                roundManager = GameManager.Instance.RoundManager;
                return;
            }
            Destroy(gameObject);
        }

        private void OnDestroy()
        {
            if (Instance == this)
            {
                Instance = null;
            }
        }

        private void Start()
        {
            roundManager = GameManager.Instance.RoundManager;
            StartCoroutine(SpawnEnemy());
        }

        private IEnumerator SpawnEnemy()
        {
            while (true)
            {
                yield return new WaitForSeconds(1f);
                yield return new WaitUntil(IsNotDestroyingObject);
                yield return new WaitUntil(roundManager.CanSpawnEnemy);
                GameObject enemySpawned = Instantiate(roundManager.GetEnemy(),startPosition.position,Quaternion.identity);
                HealthBehaviour healthBehaviour = enemySpawned.GetComponent<HealthBehaviour>();
                if (healthBehaviour)
                {
                    healthBehaviour.onDeath.AddListener(RemoveEnemy);
                }
                _enemiesSpawned.Add(enemySpawned);   
                roundManager.RegisterEnemySpawned(enemySpawned);
                yield return null;
            }
        }

        private void RemoveEnemy(GameObject enemy)
        {
            _isDestroyingObject = true;
            _enemiesSpawned.Remove(enemy);
            Destroy(enemy);
            _isDestroyingObject = false;
        }

        private bool IsNotDestroyingObject()
        {
            return !_isDestroyingObject;
        }
    }
}
