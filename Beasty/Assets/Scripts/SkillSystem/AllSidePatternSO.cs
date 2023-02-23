using DN.SkillSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skills/AllSideAttack")]

public class AllSidePatternSO : AttackPatternSO
{
    private float angleDegrees = 15f;
    public override void Perform(Transform shootingStartPoint)
    {
        Instantiate(projectile, shootingStartPoint.position, shootingStartPoint.rotation);
        Instantiate(projectile, shootingStartPoint.position, shootingStartPoint.rotation * Quaternion.Euler(Vector3.forward * angleDegrees));
        Instantiate(projectile, shootingStartPoint.position, shootingStartPoint.rotation * Quaternion.Euler(Vector3.forward * -angleDegrees));
    }
}
