using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
    public string scene;
    public Movement movement;
    public GameObject pauseMenu;

    public void PauseGame() {
        Time.timeScale = 0f;
        gameObject.SetActive(false);
        pauseMenu.SetActive(true);
    }

    public void ResumeGame() {
        gameObject.SetActive(true);
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RestartGame() {
        Time.timeScale = 1f;
        movement.Reset();
        pauseMenu.SetActive(false);
        gameObject.SetActive(true);
    }

    public void QuitToMain() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(scene);
    }
}