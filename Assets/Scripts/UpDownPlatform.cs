using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownPlatform : MonoBehaviour
{
    float StartingPoint;
    float EndPoint;
    public float DistanceToBeMoved=2f;
    public float PlatformSpeed = 3;
    bool endpoint;

    // Start is called before the first frame update
    void Start()
    {
        StartingPoint = transform.position.y;
        EndPoint = StartingPoint + DistanceToBeMoved;
    }

    // Update is called once per frame
    void Update()
    {
        if (endpoint)
        {
            transform.position += Vector3.up * PlatformSpeed * Time.deltaTime; // Up
        }
        else
        {
            transform.position -= Vector3.up * PlatformSpeed * Time.deltaTime; // Down
        }

        if (transform.position.y >= EndPoint)
        {
            endpoint = false;
         
        }
        if (transform.position.y <= StartingPoint)
            endpoint = true;
    }
}
