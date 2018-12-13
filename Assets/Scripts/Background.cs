using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    public Coin coin;

    void OnTouchDown()
    {
        coin.OnTouchDown();
    }
    void OnTouchUp()
    {
        coin.OnTouchUp();
    }
    void OnTouchStay()
    {
        coin.OnTouchStay();
    }
    void OnTouchExit()
    {
        coin.OnTouchExit();
    }
}
