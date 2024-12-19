using System;
using Enemies;
using UnityEngine;

namespace Environment.Defenses.Bullets
{
    public class SlowBulletBehaviour : SimpleBulletBehaviour
    {
        [SerializeField] private float durationSlow;
        [SerializeField] private float amountSlow;

        protected override void TouchEnemy(EnemyBehaviour enemy)
        {
            enemy.Slow(amountSlow,durationSlow);
            base.TouchEnemy(enemy);
        }
    }
}
