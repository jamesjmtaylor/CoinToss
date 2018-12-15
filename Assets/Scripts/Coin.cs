using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
    //speed in degrees of rotation per frame
    public float flipSpeed = 10f;
    public float xSpeed = 10f;
    public float ySpeed = 0f;
    public float zSpeed = 0f;


    //MARK: - Touch Events
    void OnTouchDown()
    {
        SwitchCoin();
    }
    void OnTouchUp()
    {
        //Do nothing
    }
    void OnTouchStay()
    {
        //Do nothing
    }
    void OnTouchExit()
    {
        //Do nothing
    }

    //MARK: - Coin flip
    private bool isFlipping = true;
    public void SwitchCoin()
    {
        isFlipping = !isFlipping;
    }

    // Update is called once per frame
    void Update () {
        var xRotation = transform.rotation.eulerAngles.x;
        if (!isFlipping)
        {
            if ((xRotation > -5 && xRotation < 5) ||
                (xRotation > 175 && xRotation < 185))
            {
                xSpeed = 0;
            }
        }
        else
        {
            xSpeed = flipSpeed;
        }
        transform.Rotate(xSpeed, ySpeed, zSpeed); 
    }
}
