using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject gameOverPanel, LoseText, WinText;
    public string lobbyScene, actualScene;
    [SerializeField]

    private bool gameOver;
    public static event Action OnGameOver;
    public static GameManager Instance;

    public bool _gameOver { get => gameOver; }

    void Awake () {
        if (GameManager.Instance != null) {
            Destroy (this);
        } else {
            Instance = this;
        }

    }

    public void GameOver (bool win) {
        if (!gameOver) {
            OnGameOver?.Invoke ();
            gameOverPanel.SetActive (true);
            gameOver = true;
            if (win) {
                WinText.SetActive (true);
            } else {
                LoseText.SetActive (true);
            }
        }

    }

    public void ReloadScene () {
        SceneManager.LoadScene (actualScene);
    }
    public void GoToLobbyScene () {
        SceneManager.LoadScene (lobbyScene);
    }
}