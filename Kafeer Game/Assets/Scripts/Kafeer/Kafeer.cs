using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kafeer : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocity;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector3(velocity*Time.deltaTime, 0, 0);
    }
}
