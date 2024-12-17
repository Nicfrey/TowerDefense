using System;
using Enemies;
using UnityEngine;

namespace Environment.Defenses.Bullets
{
    public class SimpleBulletBehaviour : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private int damage;
        public EnemyBehaviour Target { get; set; }

        private void Start()
        {
            if (Target)
            {
                Target.GetComponent<HealthBehaviour>().onDeath.AddListener(DestroyBullet);
            }
        }

        private void DestroyBullet(GameObject enemy)
        {
            if (Target.gameObject == enemy)
            {
                Destroy(gameObject);
            }
        }

        void Update()
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
                HealthBehaviour health = other.GetComponent<HealthBehaviour>();
                health.TakeDamage(damage);
                Destroy(gameObject);
            }
        }
    }
}
