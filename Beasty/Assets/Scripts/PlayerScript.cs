using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DN.SkillSystem;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] Skill skill;

    [SerializeField] private float movementSpeed;

    private Vector2 movementVector;
    private Vector3 mousePos;
    private Quaternion rotation;

    void Start()
    {

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            skill.PerformAttack();
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
}
