using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombCollider : MonoBehaviour
{
    public GameObject Blast;
    public Transform BlastPosition;
    public GameObject BlastFooter;
    private Bomb bomb;

    private void Start()
    {
        bomb = FindObjectOfType<Bomb>();
    }


    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Buildings")
        {
            bomb.score+=100;
            Destroy(target.gameObject);
            Destroy(this.gameObject);
            GameObject blast = Instantiate(Blast, BlastPosition.position, transform.rotation);
            Destroy(blast, 0.5f);
            
            
        }
        else if (target.gameObject.tag == "Footer")
        {
            Destroy(this.gameObject);
            GameObject footerBlast = Instantiate(BlastFooter, BlastPosition.position, transform.rotation);
            Destroy(footerBlast, 0.5f);
        }
        }
}
