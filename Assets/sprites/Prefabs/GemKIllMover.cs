using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemKIllMover : MonoBehaviour
{
    public float speed = 1.0f;
    public AudioClip Audio;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("đầu lâu đã va chạm với player");
            FindObjectOfType<AudioManager>().PlayAudio(Audio);
            Destroy(gameObject);
            Debug.Log("đã xóa đầu lâu");
            FindObjectOfType<ScoreManager>().GameOver();
        }
        else if (other.gameObject.CompareTag("Ground"))
        {
            Debug.Log("đầu lâu đã va chạm với ground");
            Destroy(gameObject);
            Debug.Log("đã xóa đầu lâu");
        }
    }
}
