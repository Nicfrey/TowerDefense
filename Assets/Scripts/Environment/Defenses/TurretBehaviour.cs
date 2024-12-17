using System;
using System.Collections;
using Enemies;
using UnityEngine;

namespace Environment.Defenses
{
    public class TurretBehaviour : DefenseBehaviour
    {
        [SerializeField] protected Transform baseTurret;
        [SerializeField] protected Transform muzzle;
        
        [SerializeField] protected float fireRate;
        protected EnemyBehaviour EnemyTarget = null;
        
        public bool HasTarget()
        {
            return EnemyTarget;
        }

        public void Awake()
        {
            StartCoroutine(ShootRoutine());
        }

        private void Update()
        {
            if (HasTarget())
            {
                baseTurret.LookAt(EnemyTarget.gameObject.transform.position);
                baseTurret.forward = new Vector3(baseTurret.forward.x, 0, baseTurret.forward.z);
                muzzle.LookAt(EnemyTarget.gameObject.transform.position);
                muzzle.forward = new Vector3(baseTurret.forward.x, 0, baseTurret.forward.z);
            }
        }

        protected IEnumerator ShootRoutine()
        {
            while (true)
            {
                yield return new WaitForSeconds(fireRate);
                yield return new WaitUntil(HasTarget);
                Debug.DrawRay(baseTurret.position, baseTurret.forward, Color.red, 0.5f);
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (HasTarget())
            {
                return;
            }
            
            EnemyBehaviour enemy = other.GetComponent<EnemyBehaviour>();
            if (enemy)
            {
                EnemyTarget = enemy;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (!HasTarget())
            {
                return;
            }
            EnemyBehaviour enemy = other.GetComponent<EnemyBehaviour>();
            if (enemy && EnemyTarget == enemy)
            {
                RemoveTarget();
            }
        }

        protected void RemoveTarget()
        {
            EnemyTarget = null;
        }
    }
}
