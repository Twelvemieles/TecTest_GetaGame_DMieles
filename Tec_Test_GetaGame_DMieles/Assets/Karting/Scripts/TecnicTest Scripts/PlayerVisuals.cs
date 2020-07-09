using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVisuals : MonoBehaviour {
    public GameObject[] hats;
    public Mesh[] meshWheels;
    public GameObject[] wheels;
    // Start is called before the first frame update
    void Start () {
        if (!PlayerPrefs.HasKey ("Hat")) {
            PlayerPrefs.SetInt ("Hat", 0);
        }
        if (!PlayerPrefs.HasKey ("KartColor")) {
            PlayerPrefs.SetInt ("KartColor", 0);
        }
        if (!PlayerPrefs.HasKey ("Wheel")) {
            PlayerPrefs.SetInt ("Wheel", 0);
        }

    }
    public void SetVisuals () {
        hats[PlayerPrefs.GetInt ("Hat")].SetActive (true);

    }

    // Update is called once per frame
    void Update () {

    }
}