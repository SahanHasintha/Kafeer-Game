using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBulletSpawn : MonoBehaviour
{
    public GameObject TerroristBullet, BulletStartPosutionFire;
    public GameObject[] BulletSpawnPositions;
    public Transform Parent;
    private Grass grass;
    
    void Start()
    {
        
        grass = GameObject.FindObjectOfType<Grass>();
        StartCoroutine(SpawnBullet());
    }

    private void Update()
    {
        
    }

    IEnumerator SpawnBullet()
    {
        yield return new WaitForSeconds(0.05f);
        GameObject ChooseOne = BulletSpawnPositions[Random.Range(0, 3)];
        GameObject xxx = Instantiate(TerroristBullet, ChooseOne.transform.position, ChooseOne.transform.rotation);
        xxx.transform.SetParent(Parent);
        GameObject bulletStartPosutionFire = Instantiate(BulletStartPosutionFire, ChooseOne.transform.position, ChooseOne.transform.rotation);
        bulletStartPosutionFire.transform.SetParent(Parent);
        Destroy(bulletStartPosutionFire, 0.1f);


        StartCoroutine(SpawnBullet());        
    }
}
