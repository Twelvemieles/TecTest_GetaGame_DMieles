using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    public ArcadeKart.StatPowerup StatsPowerUp;
    public AIKart.StatPowerup AIStatsPowerUp;

    void OnTriggerEnter (Collider other) {

        //TODO PU
        if (other.CompareTag ("Player")) {
            other.GetComponentInParent<ArcadeKart> ().AddPowerup (StatsPowerUp);
        }
        if (other.CompareTag ("AI")) {
            other.GetComponentInParent<AIKart> ().AddPowerup (AIStatsPowerUp);
        }

    }
}