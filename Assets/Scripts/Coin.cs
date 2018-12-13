using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
    //sppeed in degrees of rotation per frame
    public float xSpeed = 5f;
    public float ySpeed = 0f;
    public float zSpeed = 0f;

    void OnTouchDown()
    {
        xSpeed = 0f;
    }
    void OnTouchUp()
    {
        xSpeed = 5f;
    }
    void OnTouchStay()
    {
        xSpeed = 0f;
    }
    void OnTouchExit()
    {
        xSpeed = 5f;
    }

    // Update is called once per frame
    void Update () {
        transform.Rotate(xSpeed,ySpeed,zSpeed);
    }
    
}
