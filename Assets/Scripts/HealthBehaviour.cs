using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthBehaviour : MonoBehaviour
{
    [SerializeField] private int health = 100;
    
    public int Health => health;
    public bool IsDead => health <= 0;
    
    public UnityEvent<GameObject> onDeath;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (IsDead)
        {
            onDeath.Invoke(gameObject);
        }
    }

    public void Kill()
    {
        health = 0;
        onDeath.Invoke(gameObject);
    }
}
