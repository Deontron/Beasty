using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBulletScript : MonoBehaviour
{
    [SerializeField] private Transform[] bullets;
    [SerializeField] private Transform gun;
    private int bulletAmount;
    private int bulletCounter = 0;

    private bool canFire = true;
    [SerializeField] private float coolDown = 1;
    private float coolDownTimer = 0;
    private bool fired;

    private void Start()
    {
        bulletAmount = bullets.Length;
    }
    private void Update()
    {
        //Fire cooldown
        if (fired)
        {
            if (coolDownTimer < coolDown)
            {
                canFire = false;
                coolDownTimer += Time.deltaTime;
            }
            else
            {
                coolDownTimer = 0;
                canFire = true;
                fired = false;
            }
        }
    }

    public void FireBullet()
    {
        fired = true;

        if (bulletCounter < bulletAmount && canFire)
        {
            bullets[bulletCounter].gameObject.SetActive(true);
            bullets[bulletCounter].transform.position = gun.position;
            bullets[bulletCounter].transform.rotation = transform.rotation;

            bulletCounter++;
        }

        if (bulletCounter == (bulletAmount))
        {
            bulletCounter = 0;
        }
    }
}