using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
    public float xBound;
    public float tme;

    public void Update()
    {
        if (transform.localPosition.x < xBound)
        {
            transform.localPosition = new Vector3(0, transform.localPosition.y,transform.localPosition.z);
        }
         tme = -8*Time.deltaTime;
        
       
        transform.Translate(tme, 0f, 0f);
        
    }

    

    
}
