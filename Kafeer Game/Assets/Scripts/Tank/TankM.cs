using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankM : MonoBehaviour
{
    public GameObject x, y;
    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Missile")
        {
            x.SetActive(false);
            y.SetActive(false);
        }
    }
}
