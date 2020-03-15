using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bats : MonoBehaviour
{
    private Grass grass;

    void Update()
    {
        grass = GameObject.FindObjectOfType<Grass>();
        transform.Translate(grass.tme*1.3f, 0, 0);

    }
}
