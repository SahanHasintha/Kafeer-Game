using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public GameObject x, y;
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "PassedPosition")
        {
            //print("Collide");
        }
    }

    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Missile")
        {
            x.SetActive(false);
            y.SetActive(false);
        }
    }
}
