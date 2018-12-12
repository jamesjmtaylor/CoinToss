using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour {
    //sppeed in degrees of rotation per frame
    public float xSpeed = 5f;
    public float ySpeed = 0f;
    public float zSpeed = 0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(xSpeed,ySpeed,zSpeed);
    }
}
