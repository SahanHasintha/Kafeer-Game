using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    private Grass grass;
    
    void Update()
    {
        grass = GameObject.FindObjectOfType<Grass>();
        transform.Translate(grass.tme, 0, 0);
        
    }
}
