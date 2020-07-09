using System;
using System.Collections.Generic;
using UnityEngine;

public class FinalGoal : MonoBehaviour {
    public static event Action OnPlayerArrives;
    public static event Action OnAIArrives;
    public int laps;
    private int actualLap;

    void OnTriggerEnter (Collider other) {
        //TODO WinState Triggers
        if (other.CompareTag ("Player")) {

            if (actualLap == laps) { OnPlayerArrives?.Invoke (); }
            actualLap++;

        }
        if (other.CompareTag ("AI")) {

            if (actualLap == laps) { OnAIArrives?.Invoke (); }
            actualLap++;

        }
    }
}