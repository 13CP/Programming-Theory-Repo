using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private float spawnLimitXLeft = -1;
    private float spawnLimitXRight = 3;
    private float spawnLimitZTop = 1;
    private float spawnLimitZBottom = -1;
    private float spawnLimitY = 0.1f;
    private float startDelay = 0.2f;
    private float spawnInterval = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // ABSTRACTION
    void SpawnRandomBall ()
    {
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        int spawnInterval = Random.Range(1, 3);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnLimitY, Random.Range(spawnLimitZTop, spawnLimitZBottom));
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }
}
