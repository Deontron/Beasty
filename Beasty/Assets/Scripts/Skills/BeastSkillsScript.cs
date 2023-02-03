using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BeastSkillsScript : MonoBehaviour
{
    private FireBulletScript fireBullet;
    private FireBombScript fireBomb;

    private int skillId;
    private int skillAmount = 2;

    private void Start()
    {
        fireBullet = GetComponent<FireBulletScript>();
        fireBomb = GetComponent<FireBombScript>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ChangeSkill();
        }


        if (Input.GetMouseButtonDown(0))
        {
            switch (skillId)
            {
                case 0:
                    fireBullet.FireBullet();
                    break;

                case 1:
                    fireBomb.FireBomb();
                    break;

                default:
                    skillId = 0;
                    break;
            }

        }
    }

    private void ChangeSkill()
    {
        skillId++;
        if (skillId >= skillAmount)
        {
            skillId = 0;
        }
    }
}
