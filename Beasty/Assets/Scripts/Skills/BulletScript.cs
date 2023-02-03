using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    private float timer;

    private void Start()
    {
    }
    private void Update()
    {
        transform.position += transform.up * Time.deltaTime * speed;

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
