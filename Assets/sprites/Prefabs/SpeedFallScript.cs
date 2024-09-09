﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedFallScript : MonoBehaviour
{
    public GameObject gemSpeedPrefab;
    public float timer;
    public float spawnInterval = 5f;

    void Update()
    {
        timer += Time.deltaTime;
        // Kiểm tra nếu thời gian đã đủ lớn bằng hoặc lớn hơn khoảng thời gian sinh viên ngọc.
        if (timer >= spawnInterval)
        {
            SpawnGemSpeed();
            timer = 0;
        }

    }
    void SpawnGemSpeed()
    {
        /* Khai báo và tạo một biến có giá trị ngẫu nhiên trong khoảng màn hình trước khi tạo gem mới. 
        * Biến này đóng vai trò là tọa độ X (ngang) mới.
        */
        float randomX = Random.Range(-8f, 8f);
        Vector3 spawnPosition = new Vector3(randomX, 6f, 0);
        //Đưa tọa độ này vào function (hàm) Instantiate để tạo và thả viên gem mới
        Instantiate(gemSpeedPrefab, spawnPosition, Quaternion.identity);
    }
}
