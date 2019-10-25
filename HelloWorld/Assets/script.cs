using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody RB;

    public float forceZ = 200f;
    public float sideWayForce = 100f;
    void Start()
    {
        Debug.Log("Begin");
        RB.useGravity = true;
        //RB.AddForce(0, 100, 100);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //RB.useGravity = false;
        RB.useGravity = true;
        //RB.AddForce(0, 0, forceZ * Time.deltaTime);
        if (Input.GetKey("left"))
        {
            RB.AddForce(-sideWayForce, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            RB.AddForce(sideWayForce, 0, 0);
        }
        if (Input.GetKey("up"))
        {
            RB.AddForce(0, 0, sideWayForce);
        }
        if (Input.GetKey("down"))
        {
            RB.AddForce(0, 0, -sideWayForce);
        }
    }
}