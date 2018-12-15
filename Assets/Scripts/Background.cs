using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    public Coin coin;

    void OnTouchDown()
    {
        coin.SwitchCoin();
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
}
