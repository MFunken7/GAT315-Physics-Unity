using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ammo : MonoBehaviour
{
    [SerializeField] float speed = 1;
    [SerializeField] float lifeSpan = 0;
    Rigidbody rb;

    void Start()
    {
        if(lifeSpan > 0) Destroy(gameObject, lifeSpan);
        rb = GetComponent<Rigidbody>();

        rb.AddRelativeForce(Vector3.forward * speed, ForceMode.VelocityChange);
    }

    void Update()
    {
        
    }
}
