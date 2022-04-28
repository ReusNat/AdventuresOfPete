using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text highScoreText;

    public float scoreCount;
    public float highScoreCount;
    public float pps;

    public bool isAlive;


    // Start is called before the first frame update
    void Start() {
        if (PlayerPrefs.HasKey("HighScore")) {
            highScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
        isAlive = true;
    }

    // Update is called once per frame
    void Update() {

        if (isAlive) {
            scoreCount += pps * Time.deltaTime;
        } else {
            scoreCount = 0;
            isAlive = true;
        }

        if (scoreCount > highScoreCount) {
            highScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", highScoreCount);
        }
        
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        highScoreText.text = "High Score: " + Mathf.Round(highScoreCount);
    }
}
