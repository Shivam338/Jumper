using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightPlatform : MonoBehaviour
{
    public float Width;
    public float PlatformSpeed = 3;
    bool endpoint;

   

    // Update is called once per frame
    void Update()
    {
        if (endpoint == true)
            transform.position += Vector3.right * PlatformSpeed * Time.deltaTime; // Right

        else
        {
            transform.position -= Vector3.right * PlatformSpeed * Time.deltaTime;// Left
           
        }

        if (transform.position.x >= Width)
            endpoint = false;

        if (transform.position.x <= -Width)
            endpoint = true;
    }
}
