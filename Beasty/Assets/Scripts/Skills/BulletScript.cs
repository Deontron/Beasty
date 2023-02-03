using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Transform beast;
    private float speed = 10;
    private float timer;

    private void Start()
    {
        beast = GameObject.FindGameObjectWithTag("Beast").transform;
    }
    private void Update()
    {
        transform.Translate(beast.up * Time.deltaTime * speed);

        SetTimer();
    }

    private void SetTimer()
    {
        timer += Time.deltaTime;
        if (timer > 10)
        {
            timer = 0;
            gameObject.SetActive(false);
        }
    }
}
