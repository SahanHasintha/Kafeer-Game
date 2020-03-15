using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiletaryBullet : MonoBehaviour
{
    public GameObject BulletBlastInTerroTank;
    public Transform Parent;
    void Update()
    {
        transform.Translate(-0.5f, 0, 0);
       
    }

    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "DestroyablePart2")
        {
            //print("Hit the Enemy tank");
            Destroy(this.gameObject);
            GameObject xxx= Instantiate(BulletBlastInTerroTank, transform.position, transform.rotation);
            xxx.transform.SetParent(Parent);

        }
    }


}
