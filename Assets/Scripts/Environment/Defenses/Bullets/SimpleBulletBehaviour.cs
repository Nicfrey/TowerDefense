using System;
using Enemies;
using UnityEngine;

namespace Environment.Defenses.Bullets
{
    public class SimpleBulletBehaviour : MonoBehaviour
    {
        [SerializeField] protected float speed;
        [SerializeField] protected int damage;
        public EnemyBehaviour Target { get; set; }

        protected void Start()
        {
            if (Target)
            {
                Target.GetComponent<HealthBehaviour>().onDeath.AddListener(DestroyBullet);
                return;
            }
            Destroy(gameObject);
        }

        private void DestroyBullet(GameObject enemy)
        {
            if (Target.gameObject == enemy)
            {
                Destroy(gameObject);
            }
        }

        protected void Update()
        {
            if (Target)
            {
                transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, speed * Time.deltaTime);
                transform.forward = Vector3.MoveTowards(transform.forward, Target.transform.forward, speed * Time.deltaTime);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            EnemyBehaviour enemy = other.GetComponent<EnemyBehaviour>();
            if (enemy && enemy == Target)
            {
                TouchEnemy(enemy);
            }
        }

        protected virtual void TouchEnemy(EnemyBehaviour enemy)
        {
            HealthBehaviour health = enemy.GetComponent<HealthBehaviour>();
            health.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
