using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMove : MonoBehaviour {

    public float speed = 3.4f;
    public Camera mainCamera;

    // Update is called once per frame
    void Update() {
        Time.timeScale = 1f;
        transform.position += new Vector3(speed*Time.deltaTime, 0, 0);
        
        if (transform.position.x > mainCamera.transform.position.x + 10) {
            transform.position = new Vector3(-9.5f,-2.8f,0);
        }
    }
}
