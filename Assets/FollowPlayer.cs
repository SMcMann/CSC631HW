using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Guy;
    public Vector3 offset;
    public Vector3 birdeye;
    // Update is called once per frame
    void Start()
    {
        transform.position = Guy.position + offset;
    }
    void Update()
    {
        
       transform.position = Guy.position + offset;
        if (Input.GetKey("s"))
        {
            transform.position = birdeye ;
        }
        if (Input.GetKey("w"))
        {
            transform.position = Guy.position + offset;
        }
    }
}
