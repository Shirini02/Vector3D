using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3d : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 startpoint;
    public Vector3 endpoint;
    public Vector3 distance;
    // Start is called before the first frame update
    void Start()
    {
        print("Welcome To the Game");
        print("Use KeyBoard to play the Game");
        print("Use W to Move up");
        print("Use S to Move down");
        print("Use A to Move Left");
        print("Use D to Move Right");
        print("Use Q to Move forward");
        print("Use E to Move Back");

        distance = startpoint - endpoint;
        print("Distance is:" + distance.magnitude);
        if (startpoint.magnitude > endpoint.magnitude)
        {
            print("Move Forward");
        }
        else if (startpoint.magnitude < endpoint.magnitude)
        {
            print("Move Backward");
        }
        else
        {
            print("You Reached the destinaton");
        }



    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement(KeyCode.W, new Vector3(0, 1, 0));
        PlayerMovement(KeyCode.S, new Vector3(0, -1, 0));
        PlayerMovement(KeyCode.A, new Vector3(-1, 0, 0));
        PlayerMovement(KeyCode.D, new Vector3(1, 0, 0));
        PlayerMovement(KeyCode.Q, new Vector3(0, 0, 1));
        PlayerMovement(KeyCode.E, new Vector3(0, 0, -1));


    }

    private void PlayerMovement(KeyCode arrow, Vector3 values)
    {
        Method(arrow, values);
    }
    private void Method(KeyCode arrow, Vector3 values)
    {
        if (Input.GetKeyDown(arrow))
        {
            startpoint = startpoint + values;
            distance = startpoint - endpoint;
            print("Distance is: " + distance);
            if (startpoint == endpoint)
            {
                print("You reached your Denstination");
            }

        }
    }
}
