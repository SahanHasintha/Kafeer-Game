using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerroristBullet : MonoBehaviour
{
    void Update()
    {
        transform.Translate(0.5f, 0, 0);
       
    }

    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "MiletaryTank")
        {
            //print("Hit the Tank");
            Destroy(this.gameObject);
        }
        if (target.gameObject.tag == "TankBullet")
        {
            //print("Hit the Bullet");
            Destroy(this.gameObject);
            Destroy(target.gameObject);
        }
    }


}
