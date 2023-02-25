using DN.HealthSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IHealth
{
    public float bulletSpeed;
    public float bulletDamage;

    public float health { get; set; }

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * bulletSpeed;
        Destroy(gameObject, 10);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IHealth health = collision.GetComponent<IHealth>();
        if (health != null)
        {
            health.GetHit(bulletDamage, gameObject);
        }
    }

    public void GetHit(float damage, GameObject sender)
    {
        print(sender.name);
        Destroy(gameObject);
    }
}
