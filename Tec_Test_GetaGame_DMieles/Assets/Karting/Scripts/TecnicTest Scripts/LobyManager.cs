using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobyManager : MonoBehaviour {

    public string TimeTrialScene, VsPc;

    public void GoToTimeTrial () {
        SceneManager.LoadScene (TimeTrialScene);
    }
    public void GoToVsPc () {
        SceneManager.LoadScene (VsPc);
    }
}