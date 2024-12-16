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
        [SerializeField] private GameObject[] enemyPrefabs;
        private List<GameObject> _enemiesSpawned = new ();
        private bool _isDestroyingObject;

        private void Awake()
        {
            if (!Instance)
            {
                Instance = this;
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
            StartCoroutine(SpawnEnemy());
        }

        private IEnumerator SpawnEnemy()
        {
            while (true)
            {
                yield return new WaitForSeconds(1f);
                yield return new WaitUntil(IsNotDestroyingObject);
                GameObject enemySpawned = Instantiate(enemyPrefabs[0],startPosition.position,Quaternion.identity);
                HealthBehaviour healthBehaviour = enemySpawned.GetComponent<HealthBehaviour>();
                if (healthBehaviour)
                {
                    healthBehaviour.onDeath.AddListener(RemoveEnemy);
                }
                _enemiesSpawned.Add(enemySpawned);   
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
