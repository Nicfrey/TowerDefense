using System;
using System.Collections;
using Enemies;
using Environment.Defenses.Bullets;
using UnityEngine;
using UnityEngine.Serialization;

namespace Environment.Defenses
{
    public class TurretBehaviour : DefenseBehaviour
    {
        [SerializeField] protected Transform baseTurret;
        [SerializeField] protected Transform turretPivot;
        [SerializeField] protected Transform muzzleTurret;
        
        [SerializeField] protected GameObject bulletPrefab;
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

        protected void Update()
        {
            if (HasTarget())
            {
                baseTurret.LookAt(EnemyTarget.gameObject.transform.position);
                baseTurret.forward = new Vector3(baseTurret.forward.x, 0, baseTurret.forward.z);
                turretPivot.LookAt(EnemyTarget.gameObject.transform.position);
                turretPivot.forward = new Vector3(baseTurret.forward.x, 0, baseTurret.forward.z);
            }
        }

        protected IEnumerator ShootRoutine()
        {
            while (true)
            {
                yield return new WaitForSeconds(fireRate);
                yield return new WaitUntil(HasTarget);
                Debug.DrawRay(baseTurret.position, baseTurret.forward, Color.red, 0.5f);
                GameObject bullet = Instantiate(bulletPrefab, muzzleTurret.position, turretPivot.rotation);
                bullet.GetComponent<SimpleBulletBehaviour>().Target = EnemyTarget;
            }
        }

        protected void OnTriggerStay(Collider other)
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

        protected void OnTriggerExit(Collider other)
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
