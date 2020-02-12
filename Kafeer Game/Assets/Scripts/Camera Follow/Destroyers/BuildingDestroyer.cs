using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingDestroyer : MonoBehaviour
{
    private int x;
    private Bomb bomb;

    private void Start()
    {
        bomb = FindObjectOfType<Bomb>();
        x = 0;
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "FullBuilding")
        {
            x++;
          
            Destroy(target.gameObject);
            if (x == 7)
            {
                bomb.gameLost = true;
            }
        }

    }
    

}
