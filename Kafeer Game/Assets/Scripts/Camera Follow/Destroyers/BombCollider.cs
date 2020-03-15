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
    public int marksForDestroyablePart01;
    public int marksForDestroyablePart03;
    public int marksForTankCollide;
   

    private void Start()
    {
        bomb = FindObjectOfType<Bomb>();
        
    }


    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "DestroyablePart")
        {
            bomb.score+=marksForDestroyablePart01;
            Destroy(target.gameObject);
            Destroy(this.gameObject);
            GameObject blast = Instantiate(Blast, BlastPosition.position, transform.rotation);
            Destroy(blast, 0.5f);  
        }
        if (target.gameObject.tag == "DestroyablePart2")
        {
            bomb.score += marksForTankCollide;
            Destroy(target.gameObject);
            Destroy(this.gameObject);
            GameObject blast = Instantiate(Blast, BlastPosition.position, transform.rotation);
            Destroy(blast, 0.5f);
        }
        if (target.gameObject.tag == "DestroyablePart3")
        {
            bomb.score += marksForDestroyablePart03;
            Destroy(target.gameObject);
            Destroy(this.gameObject);
            GameObject blast = Instantiate(Blast, BlastPosition.position, transform.rotation);
            Destroy(blast, 0.5f);
        }
        if (target.gameObject.tag == "Footer")
        {
            Destroy(this.gameObject);
            GameObject footerBlast = Instantiate(BlastFooter, BlastPosition.position, transform.rotation);
            Destroy(footerBlast, 0.5f);
        }
        if (target.gameObject.tag == "MiletaryTank")
        {
            bomb.gameLost = true;
            Destroy(target.gameObject);
            Destroy(this.gameObject);
            GameObject blast = Instantiate(Blast, BlastPosition.position, transform.rotation);
            Destroy(blast, 0.5f);
        }
    }
}
