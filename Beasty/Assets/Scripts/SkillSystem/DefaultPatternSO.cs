using DN.SkillSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Skills/DefaultAttack")]

public class DefaultPatternSO : AttackPatternSO
{
    public List<GameObject> bullets = new List<GameObject>();
    private GameObject magazine;
    private int bulletIndex = 0;
    public override void Perform(Transform shootingStartPoint)
    {
        if (bullets.Count > 0)
        {
            FireTheBullet(shootingStartPoint);

            bulletIndex++;
            bulletIndex = bulletIndex >= bullets.Count ? 0 : bulletIndex;
        }
        else
        {
            GetBullets();
        }
        //Instantiate(projectile, shootingStartPoint.position, shootingStartPoint.rotation);
    }

    private void FireTheBullet(Transform shootingStartPoint)
    {
        bullets[bulletIndex].GetComponent<Bullet>().ResetBulletMovement();
        bullets[bulletIndex].transform.position = shootingStartPoint.position;
        bullets[bulletIndex].transform.rotation = shootingStartPoint.rotation;
        bullets[bulletIndex].GetComponent<Bullet>().BulletMovement();
    }

    private void GetBullets()
    {
        magazine = GameObject.FindGameObjectWithTag("PlayerBulletMagazine");

        for (int i = 0; i < magazine.transform.childCount; i++)
        {
            bullets.Add(magazine.transform.GetChild(i).gameObject);
        }
    }
}
