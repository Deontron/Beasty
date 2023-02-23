using DN.SkillSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skills/DefaultAttack")]

public class DefaultPatternSO : AttackPatternSO
{
    public override void Perform(Transform shootingStartPoint)
    {
        Instantiate(projectile, shootingStartPoint.position, shootingStartPoint.rotation);
    }
}
