using System;
using System.Collections;
using UnityEngine;

public class PickUpTime : MonoBehaviour {
    public delegate void CarPicks (float timeGainValue);
    public static event CarPicks OnCarPicks;
    public float TimeGainValue;

    private void OnTriggerEnter (Collider other) {
        //TODO Player Picks more time
        if (other.CompareTag ("Player")) {
            if (OnCarPicks != null) OnCarPicks (TimeGainValue);
            gameObject.SetActive (false);
        }
    }
}