using DN.SkillSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skills/BombAttack")]

public class BombPatternSO : AttackPatternSO
{
    public override void Perform(Transform shootingStartPoint)
    {
        Instantiate(projectile, shootingStartPoint.position, shootingStartPoint.rotation);
    }
}
