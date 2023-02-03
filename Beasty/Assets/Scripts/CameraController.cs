using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float speed;

    private Vector3 velocity = Vector3.zero;


    void Start()
    {
        
    }

    void FixedUpdate()
    {
        
        transform.position = Vector3.SmoothDamp(transform.position, target.position + offset, ref velocity, speed);
    }
}
