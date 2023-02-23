using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DN.SkillSystem
{
    public class Skill : MonoBehaviour
    {
        [SerializeField]
        private AttackPatternSO attackPattern;

        [SerializeField]
        private Transform shootinfStartPoint;

        private bool shootingDelayed;

        public void PerformAttack()
        {
            if (!shootingDelayed)
            {
                shootingDelayed = true;
                attackPattern.Perform(shootinfStartPoint);

                StartCoroutine(DelayShooting());
            }
        }

        IEnumerator DelayShooting()
        {
            yield return new WaitForSeconds(attackPattern.AttackDelay);
            shootingDelayed = false;
        }
    }
}