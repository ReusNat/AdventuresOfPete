using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {
    public Camera mainCamera;
    public ScoreManager scoreManager;

    private void Update() {
        myDestroy();
    }

    public void myDestroy() {
        GameObject[] platforms = GameObject.FindGameObjectsWithTag("Platforms");
        foreach (GameObject obstical in platforms) {
            if (obstical.name == "Platform(Clone)") {
                if (obstical.transform.position.y < (mainCamera.transform.position.y - 6) || obstical.transform.position.y > mainCamera.transform.position.y + 6
                    || !scoreManager.isAlive) {
                    Destroy(obstical);
                }
            }
        }
    }
}
