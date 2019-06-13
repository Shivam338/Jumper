using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollower : MonoBehaviour
{

    public Transform Player;
    public Transform Platform;
    public Transform SpecialPlatform;
    public Transform UpDownPlatform;
    public Transform LeftRightPlatform;

    public float Distance = 5; // Distance between the end of screen and the camera

    [System.Obsolete]
    void LateUpdate()
    {
        if (Player.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, Player.position.y, transform.position.z);
            transform.position = newPos;
        }
        else if(Player.position.y < (transform.position.y - 5f))
        {
            Application.LoadLevel(Application.loadedLevel);
        }



        //if(Platform.position.y < ObjDestroy || SpecialPlatform.position.y < ObjDestroy || UpDownPlatform.position.y < ObjDestroy || LeftRightPlatform.position.y < ObjDestroy)
        //{
        //    Debug.Log("Working...destroy..");

        /* if (Platform)
             Destroy(Platform);

         if(SpecialPlatform)
             Destroy(SpecialPlatform);

         if (UpDownPlatform)
             Destroy(UpDownPlatform);

         if (LeftRightPlatform)
             Destroy(LeftRightPlatform); 
     } */
    }
}
