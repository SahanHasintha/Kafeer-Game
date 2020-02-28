using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TNTSpawn : MonoBehaviour
{
    public GameObject TNT;
    public Transform TNTSpawnPosition;
    private int x,y;
    public Transform parent;
    public Text HowManyTnt;

    private void Start()
    {
        y = 5;
        x = 0;
    }

    public void TntSpawn()
    {
        y--;
        HowManyTnt.text = y.ToString();
        StartCoroutine(TntSpawner());
    }

    IEnumerator TntSpawner()
    {
        
        yield return new WaitForSeconds(0.5f);
        GameObject tnt = Instantiate(TNT, TNTSpawnPosition.position, TNTSpawnPosition.rotation);
        //tnt.transform.SetParent(parent);
        x++;
        Coroutine a = StartCoroutine(TntSpawner());
        if (x == 5)
        {
            StopCoroutine(a);
            x = 0;
        }

    }

    
}
