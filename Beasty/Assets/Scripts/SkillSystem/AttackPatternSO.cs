using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DN.SkillSystem
{
    public abstract class AttackPatternSO : ScriptableObject
    {
        [SerializeField] protected float attackDelay = 1f;

        public float AttackDelay => attackDelay;

        [SerializeField] protected GameObject projectile;

        public GameObject Projectile => projectile;

        public abstract void Perform(Transform shootingStartPoint);
    }
}