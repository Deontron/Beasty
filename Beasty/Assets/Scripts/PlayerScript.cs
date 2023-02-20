using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float movementSpeed;

    private Vector2 movementVector;
    private Vector3 mousePos;
    private Quaternion rotation;

    void Start()
    {

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
