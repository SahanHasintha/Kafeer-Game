using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject kafeer;
    private float offset;
    void Start()
    {
        offset = transform.position.x - kafeer.transform.position.x;
    }

    void Update()
    {
        transform.position = new Vector3(kafeer.transform.position.x + offset, transform.position.y, transform.position.z);
    }
}
