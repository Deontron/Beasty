using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DN.SkillSystem
{
    public class Skill : MonoBehaviour
    {
        [SerializeField]
        private AttackPatternSO[] attackPatterns;

        [SerializeField]
        private AttackPatternSO attackPattern;
        private int index = 0;

        [SerializeField]
        private Transform shootingStartPoint;

        private bool shootingDelayed;

        public void PerformAttack()
        {
            if (!shootingDelayed)
            {
                shootingDelayed = true;
                attackPattern.Perform(shootingStartPoint);

                StartCoroutine(DelayShooting());
            }
        }

        IEnumerator DelayShooting()
        {
            yield return new WaitForSeconds(attackPattern.AttackDelay);
            shootingDelayed = false;
        }

        public void ChangeSkill()
        {
            index++;
            index = index >= attackPatterns.Length ? 0 : index;
            attackPattern = attackPatterns[index];
        }
    }
}