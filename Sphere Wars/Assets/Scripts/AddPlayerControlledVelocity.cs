using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AddPlayerControlledVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 viteza;

    [SerializeField]
    KeyCode keyPositive;
    [SerializeField]
    KeyCode keyNegative;

    void FixedUpdate()
    {
        if (Input.GetKey(keyPositive))
            GetComponent<Rigidbody>().velocity += viteza;

        if (Input.GetKey(keyNegative))
            GetComponent<Rigidbody>().velocity -= viteza;
    }
}
