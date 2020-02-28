using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNT : MonoBehaviour
{
    private Grass grass;
    private Bomb bomb;
    public GameObject BlastPosition;
    public GameObject TntBlast1, TntBlast2;
    private void Start()
    {
        
        grass = GameObject.FindObjectOfType<Grass>();
        bomb = GameObject.FindObjectOfType<Bomb>();
    }
    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Footer")
        {
            GameObject BlastTnt1 = Instantiate(TntBlast1, BlastPosition.transform.position, BlastPosition.transform.rotation);
            Destroy(this.gameObject);
            Destroy(BlastTnt1, 0.5f);
           
        }
        if(target.gameObject.tag == "Buildings")
        {
            GameObject BlastTnt2 = Instantiate(TntBlast2, BlastPosition.transform.position, BlastPosition.transform.rotation);
            Destroy(this.gameObject);
            Destroy(BlastTnt2, 0.5f);
            Destroy(target.gameObject);
        }
    }
   

}
