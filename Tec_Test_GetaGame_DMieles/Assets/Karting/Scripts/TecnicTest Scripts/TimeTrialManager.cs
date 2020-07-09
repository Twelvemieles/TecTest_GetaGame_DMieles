using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeTrialManager : MonoBehaviour {
    [SerializeField]
    private float initialTime, actualTime;
    public Text timeText;
    private GameManager gameManager;

    void Start () {
        actualTime = initialTime;
        gameManager = GameManager.Instance;
    }
    public void LoseState () {

        gameManager.GameOver (false);
    }
    public void WinState () {
        gameManager.GameOver (true);
    }
    void OnEnable () {
        PickUpTime.OnCarPicks += AddTime;
        FinalGoal.OnPlayerArrives += WinState;
    }
    void OnDisable () {
        PickUpTime.OnCarPicks -= AddTime;
        FinalGoal.OnPlayerArrives -= WinState;
    }

    void Update () {
        //Time redution and draw
        if (!gameManager._gameOver) {
            actualTime -= Time.deltaTime;

            //TODO LoseState Triggers
            if (actualTime <= 0f) {
                LoseState ();
                actualTime = 0;
            }
            timeText.text = actualTime.ToString ("00.00");
        }
    }
    private void AddTime (float value) {
        //TODO Player Picks more time

        actualTime += value;
    }
}