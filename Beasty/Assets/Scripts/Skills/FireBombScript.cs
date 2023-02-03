using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBombScript : MonoBehaviour
{
    [SerializeField] private Transform[] bombs;
    [SerializeField] private Transform gun;
    private int bombAmount;
    private int bombCounter = 0;

    private bool canFire = true;
    [SerializeField] private float coolDown = 1;
    private float coolDownTimer = 0;
    private bool fired;

    private void Start()
    {
        bombAmount = bombs.Length;
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

    public void FireBomb()
    {
        fired = true;

        if (bombCounter < bombAmount && canFire)
        {
            bombs[bombCounter].gameObject.SetActive(true);
            bombs[bombCounter].transform.position = gun.position;
            bombs[bombCounter].transform.rotation = transform.rotation;

            bombCounter++;
        }

        if (bombCounter == (bombAmount))
        {
            bombCounter = 0;
        }
    }
}