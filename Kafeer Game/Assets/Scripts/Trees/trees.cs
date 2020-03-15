using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trees : MonoBehaviour
{
    private Bomb bomb;
    public GameObject[] Buildings;
    public Transform Parent;
    public float timeMin, timeMax;
    public int buildingMinValue, buildingMaxValue;


    void Start()
    {
        bomb = GameObject.FindObjectOfType<Bomb>();
        StartCoroutine(SpawnBulding01());
    }
    private void Update()
    {
        if(bomb.gameLost==true || bomb.gameWin == true)
        {
            StopAllCoroutines();
        }
    }

    IEnumerator SpawnBulding01()
    {


        yield return new WaitForSeconds(Random.Range(timeMin, timeMax));
        GameObject xxx = Instantiate(Buildings[Random.Range(buildingMinValue, buildingMaxValue)], transform.position, transform.rotation);
        xxx.transform.SetParent(Parent);
        StartCoroutine(SpawnBulding01());
        

    }
}
