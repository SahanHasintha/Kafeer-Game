using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawn : MonoBehaviour
{
    public GameObject[] Buildings;
    public Transform Parent;
    public float timeMin, timeMax;
    public int buildingMinValue, buildingMaxValue;
    private int x;
    public int numberOfHouses;


    void Start()
    {
        x = 0;
        StartCoroutine(SpawnBulding01());
    }

    IEnumerator SpawnBulding01()
    {
        
       
        yield return new WaitForSeconds(Random.Range(timeMin, timeMax));
        GameObject xxx = Instantiate(Buildings[Random.Range(buildingMinValue, buildingMaxValue)], transform.position, transform.rotation);
        xxx.transform.SetParent(Parent);
        x++;
        StartCoroutine(SpawnBulding01());
        if (x == numberOfHouses )
        {
            StopAllCoroutines();
        }
        
    }
}
