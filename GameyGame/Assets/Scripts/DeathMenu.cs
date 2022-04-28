using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour {

    public string scene;
    public Movement movement;

    public void RestartGame() {
        Time.timeScale = 1f;
        movement.Reset();
    }

    public void QuitToMain() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(scene);
    }
}
