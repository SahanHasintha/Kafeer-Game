using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingDestroyer : MonoBehaviour
{
    private int x;
    private Bomb bomb;
    public int numberOfHouses;

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
            if (x == numberOfHouses)
            {
                bomb.gameLost = true;
            }
        }

        if (target.tag == "TNT")
        {
            Destroy(target.gameObject);
        }
        if (target.tag == "Trees"|| target.tag == "Bats")
        {
            Destroy(target.gameObject);
        }
        if (target.tag == "FullTank")
        {
            print("COllide");
            Destroy(target.gameObject);
        }

    }
}
