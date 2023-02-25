using DN.SkillSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Skills/AllSideAttack")]

public class SpreadPatternSO : AttackPatternSO
{
    [SerializeField]
    private float angleDegrees = 10f;
    public override void Perform(Transform shootingStartPoint)
    {
        Instantiate(projectile, shootingStartPoint.position, shootingStartPoint.rotation);
        Instantiate(projectile, shootingStartPoint.position, shootingStartPoint.rotation * Quaternion.Euler(Vector3.forward * angleDegrees));
        Instantiate(projectile, shootingStartPoint.position, shootingStartPoint.rotation * Quaternion.Euler(Vector3.forward * -angleDegrees));
    }
}
