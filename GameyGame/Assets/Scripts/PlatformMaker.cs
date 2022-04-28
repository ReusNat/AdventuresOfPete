using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMaker : MonoBehaviour {
    public GameObject platform;
    public float maxXDistance;
    public float spawnTime;
    public float startTime;
    public Camera mainCamera;

    private float lastPlatformX;
    private GameObject lastPlatform;
    public bool firstPlatform;
    Vector3 cameraPos;

    void Start() {
        firstPlatform = true;
        cameraPos = mainCamera.transform.position;
        InvokeRepeating("SpawnPlatform", startTime, spawnTime);
    }

    void Update() {
        cameraPos = mainCamera.transform.position;
    }
    void SpawnPlatform() {
        Vector3 position;
        if (firstPlatform) {
            position = new Vector3(0, 2.5f, 0);
            lastPlatform = Instantiate(platform, position, Quaternion.identity);
            firstPlatform = false;
            lastPlatformX = position.x;
        } else {
            float newXpos = Random.Range(lastPlatformX - maxXDistance, lastPlatformX + maxXDistance);
            if (Mathf.Abs(lastPlatformX - newXpos) < 2.5) {
                if (newXpos > 0)
                    newXpos += 5;
                else
                    newXpos -= 5;
            }
            position = new Vector3(newXpos, cameraPos.y, 0);
            lastPlatform = Instantiate(platform, position, Quaternion.identity);
            lastPlatformX = position.x;
        }
    }
}
