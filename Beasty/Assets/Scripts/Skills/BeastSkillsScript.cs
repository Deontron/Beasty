using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BeastSkillsScript : MonoBehaviour
{
    private FireBulletScript fireBullet;

    private void Start()
    {
        fireBullet = GetComponent<FireBulletScript>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            fireBullet.FireBullet();
        }
    }
}
