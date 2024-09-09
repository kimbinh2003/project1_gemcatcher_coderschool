using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemKillFallScript : MonoBehaviour
{
    public GameObject gemKill;
    public float timer;
    public float spawnInterval = 3f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnGemKill();
            timer = 0;
        }
    }
    void SpawnGemKill()
    {
        float randomX = Random.Range(-8f, 8f);
        Vector3 spawnPosition = new Vector3(randomX, 6f, 0);
        Instantiate(gemKill, spawnPosition, Quaternion.identity);

    }
}
