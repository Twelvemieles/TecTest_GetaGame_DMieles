using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VsPcManager : MonoBehaviour {
    private GameManager gameManager;
    void OnEnable () {
        gameManager = GameManager.Instance;
        FinalGoal.OnAIArrives += LoseState;
        FinalGoal.OnPlayerArrives += WinState;
    }
    void OnDisable () {

        FinalGoal.OnAIArrives -= LoseState;
        FinalGoal.OnPlayerArrives -= WinState;
    }
    public void LoseState () {

        gameManager.GameOver (false);

    }
    public void WinState () {

        gameManager.GameOver (true);

    }
}