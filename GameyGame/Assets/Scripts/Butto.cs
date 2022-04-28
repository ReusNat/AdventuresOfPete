using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Butto : MonoBehaviour {
    public string game;
    public void Play() {
        SceneManager.LoadScene(game);
    }

    public void QuitButton() {
        Application.Quit();
    }

}
