using System;
using Enemies;
using UnityEngine;

namespace Environment.Defenses.Bullets
{
    public class SlowBulletBehaviour : SimpleBulletBehaviour
    {
        [SerializeField] private float durationSlow;

        private void OnTriggerEnter(Collider other)
        {
            EnemyBehaviour enemy = other.GetComponent<EnemyBehaviour>();
            if (enemy && enemy == Target)
            {
                enemy.Slow(damage,durationSlow);
                Destroy(gameObject);
            }
        }
    }
}
