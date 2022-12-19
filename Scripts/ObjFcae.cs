using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjFcae : MonoBehaviour
{
    public Transform ObjToFollow = null;
    public bool FollowPlayer = false;

    void Awake()
    {
        if (!FollowPlayer)
        {
            return;
        }

        GameObject PlayerObj = GameObject.FindGameObjectWithTag("Player");  // Finds the game object with the tag "Player" on it
        if (PlayerObj != null)
        {
            ObjToFollow = PlayerObj.transform;
        }
    }
    // Update is called once per frame and generates a displacement vector from the object location
    void Update()
    {
        if (ObjToFollow==null)
        {
            return;
        }

        // Gets direction to follow the object
        Vector3 DirToObject = ObjToFollow.position - transform.position;

        if (DirToObject != Vector3.zero)
        {
            transform.localRotation = Quaternion.LookRotation(DirToObject.normalized, Vector3.up);
        }
    }
}



// This script will always rotate this object so that its forward vector points towards a destination point in the scene
