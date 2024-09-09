using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockPlusFallScript : MonoBehaviour
{
    public GameObject clockPlusPrefab;
    public float timer;
    public float spawnInterval = 5f;
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnGemPlus();
            timer = 0;
        }

    }
    void SpawnGemPlus()
    {
        float randomX = Random.Range(-8f, 8f);
        Vector3 spawnPosition = new Vector3(randomX, 6f, 0);
        Instantiate(clockPlusPrefab, spawnPosition, Quaternion.identity);
    }
}
