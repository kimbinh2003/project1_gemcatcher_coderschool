using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GemPlusMover : MonoBehaviour
{
    public float speed = 1f;
    public AudioClip Audio;
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other) //other chính là thông tin của bất kỳ collider nào va chạm với collider này
    {
        // thiết lập điều kiện kiểm tra thông tin của OTHER
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("viên ngọc xanh đã va chạm với game object có nhãn player");           
            ScoreManager.AddScore(+Random.Range(1,5));
            FindObjectOfType<AudioManager>().PlayAudio(Audio);
            Destroy(gameObject);
            Debug.Log("đã xóa viên ngọc này ");
        }
        else if (other.gameObject.CompareTag("Ground"))
        {
            Debug.Log("viên ngọc xanh đã va chạm với game object có nhãn ground");
            Destroy(gameObject);
            Debug.Log("đã xóa viên ngọc này");
        }

    }
}
