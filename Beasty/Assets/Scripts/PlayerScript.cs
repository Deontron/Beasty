using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DN.SkillSystem;
using DN.HealthSystem;

public class PlayerScript : MonoBehaviour, IHealth
{
    [SerializeField]
    private Skill skill;

    [SerializeField]
    private float movementSpeed;

    private Vector2 movementVector;
    private Vector3 mousePos;
    private Quaternion rotation;

    public float health { get; set; }

    void Start()
    {
        health = 100;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            skill.PerformAttack();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            skill.ChangeSkill();
        }
    }
    void FixedUpdate()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        movementVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        GetComponent<Rigidbody2D>().AddForce(movementVector * movementSpeed);

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        rotation = Quaternion.LookRotation(mousePos - transform.position, transform.TransformDirection(-Vector3.forward));
        transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);
    }

    private void Death()
    {
        Debug.Log("death");
    }

    private void GetFeedBack()
    {
        Debug.Log("auch");
    }

    public void GetHit(float damage, GameObject sender)
    {
        health -= damage;
        Debug.Log(health);

        if (health <= 0)
        {
            Death();
        }
        else
        {
            GetFeedBack();
        }
    }
}
