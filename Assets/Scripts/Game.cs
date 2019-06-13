using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public Transform Player;
    public Transform Platform;
    public Transform SpecialPlatform;
    public Transform UpDownPlatform;
    public Transform LeftRightPlatform;
    public float Width;

    float jumpHeight;  // height at which camera will adjust
    private float PlatformCheck;
    private float SpawmPlatformTo;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Mario").transform;

       // PlatformSpawner(2f);
    }

    // Update is called once per frame
    void Update()
    {
        // JumpHeight along Y axis
        jumpHeight = Player.position.y;

        if(jumpHeight > PlatformCheck)
        {
            PlatformManager();
        }

        // Camera movement
        float CameraHeight = transform.position.y;

        // Camera follower
        float CamFollower = Mathf.Lerp(CameraHeight, jumpHeight, Time.deltaTime * 10);

        if(jumpHeight > CameraHeight)
        {   
            transform.position = new Vector3(transform.position.x, CamFollower, transform.position.z);
        }
    }

    void PlatformManager()
    {
        PlatformCheck = Player.position.y + 15;
        PlatformSpawner(PlatformCheck+15);
    }

    void PlatformSpawner(float SpawnPoint)
    {
        float y = SpawmPlatformTo;

        while (y <= SpawnPoint)
        {
            float x = UnityEngine.Random.Range(-Width, Width);
            Vector2 Pos = new Vector2(x, y);

            int rand = UnityEngine.Random.Range(1, 8);


            // Special Platform
            if(rand < 1)
            {
                Instantiate(SpecialPlatform, Pos, Quaternion.identity);
            }

            // UpDown PlatForm
            else if(rand >1 && rand < 3)
            {
                Instantiate(UpDownPlatform, Pos, Quaternion.identity);
            }

            // Left-Right Platform
            else if(rand >2 && rand < 4)
            {
                Instantiate(LeftRightPlatform, Pos, Quaternion.identity);
            }

            // Platform
            else
            {
                Instantiate(Platform, Pos, Quaternion.identity);
            }

            y += UnityEngine.Random.Range(.5f, 1.75f);
        }
        SpawmPlatformTo = SpawnPoint;
    }

}
