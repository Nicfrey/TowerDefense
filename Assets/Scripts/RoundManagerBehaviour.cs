using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Enemies;
using Environment;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class RoundManagerBehaviour : MonoBehaviour
{
    [SerializeField] private Rounds roundsLevel;
    
    public int CurrentRound { get; private set; }
    public UnityEvent onGameWin;

    private int[] _enemiesNumbersCurrentRound;
    public int EnemySpawnedCurrentRound { get; private set; }
    public int NumberEnemyOfRound { get; private set; }

    public int RemainingEnemy
    {
        get
        {
            int remainingEnemy = 0;
            foreach (int i in _enemiesNumbersCurrentRound)
            {
                remainingEnemy += i;
            }
            return remainingEnemy;
        }
    }

    private void Start()
    {
        CurrentRound = 0;
        NumberEnemyOfRound = roundsLevel.roundsLevel[CurrentRound].RemainingEnemies;
        EnemySpawnedCurrentRound = 0;
        _enemiesNumbersCurrentRound = roundsLevel.roundsLevel[CurrentRound].NumberByTypeOfEnemies.ToArray();
        Debug.Log("Current Round : " + CurrentRound + " with " + NumberEnemyOfRound + " enemies");
    }

    public void RegisterEnemySpawned(GameObject enemySpawned)
    {
        EnemyBehaviour enemyBehaviour = enemySpawned.GetComponent<EnemyBehaviour>();
        int index = FindIndexEnemy(enemyBehaviour);
        if (index == -1)
            return;
        HealthBehaviour health = enemyBehaviour.GetComponent<HealthBehaviour>();
        health.onDeath.AddListener(RemoveEnemy);
        ++EnemySpawnedCurrentRound;
    }

    private void RemoveEnemy(GameObject enemy)
    {
        EnemyBehaviour enemyBehaviour = enemy.GetComponent<EnemyBehaviour>();
        int index = FindIndexEnemy(enemyBehaviour);
        if (index == -1)
            return;
        _enemiesNumbersCurrentRound[index] -= 1;
        if (CanGoNextRound())
        {
            ++CurrentRound;
            EnemySpawnedCurrentRound = 0;
            if (IsGameWin())
            {
                onGameWin?.Invoke();
            }
            else
            {
                NumberEnemyOfRound = roundsLevel.roundsLevel[CurrentRound].RemainingEnemies;
                _enemiesNumbersCurrentRound = roundsLevel.roundsLevel[CurrentRound].NumberByTypeOfEnemies.ToArray();
                Debug.Log("Current Round : " + CurrentRound + " with " + NumberEnemyOfRound + " enemies");
            }
        }
    }

    private int FindIndexEnemy(EnemyBehaviour enemy)
    {
        int index = roundsLevel.roundsLevel[CurrentRound].TypeEnemies.ToList().FindIndex(other =>
        {
            EnemyBehaviour enemyComp = other.GetComponent<EnemyBehaviour>();
            return enemyComp.EnemyType == enemy.EnemyType;
        });
        if (index == -1)
        {
            Debug.LogError("The enemy of type " + enemy.EnemyType + " is not part of the current round");
            return -1;
        }
        return index;
    }

    private bool CanGoNextRound()
    {
        return RemainingEnemy == 0;
    }

    private bool IsGameWin()
    {
        return CurrentRound >= roundsLevel.roundsLevel.Count;
    }

    public GameObject GetEnemy()
    {
        int index = GetIndexEnemy();
        Debug.Log("index found: " + index);
        if (index == -1)
        {
            Debug.LogError("Couldn't find any enemy valid");
            return null;
        }
        return roundsLevel.roundsLevel[CurrentRound].TypeEnemies[index];
    }
    
    private int GetIndexEnemy()
    {
        if (!CanSpawnEnemy())
        {
            return -1;
        }
        bool found = false;
        int index = -1;
        int attempt = 0;
        while (!found)
        {
            index = Random.Range(0, roundsLevel.roundsLevel[CurrentRound].TypeEnemies.Length);
            if (_enemiesNumbersCurrentRound[index] > 0 || attempt >= 1000)
            {
                found = true;
            }
            ++attempt;
        }
        return index;
    }

    public bool CanSpawnEnemy()
    {
        return EnemySpawnedCurrentRound != NumberEnemyOfRound;
    }
}
