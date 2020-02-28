using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutBombScript : MonoBehaviour
{
    private Bomb bomb;

    private void Start()
    {
        bomb = GameObject.FindObjectOfType<Bomb>();

    }

    public void putBomb()
    {
        bomb.SpawnBomb();
    }
}
