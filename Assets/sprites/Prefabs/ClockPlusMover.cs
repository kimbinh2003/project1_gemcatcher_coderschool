using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockPlusMover : MonoBehaviour
{
    public float speed = 1f;
    public AudioClip Audio;
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("viên ngọc vuông xanh đã va chạm với game object có nhãn player");
            FindObjectOfType<AudioManager>().PlayAudio(Audio);
            Destroy(gameObject);
            Debug.Log("đã xóa viên ngọc này ");
            FindObjectOfType<ScoreManager>().AddTimer(+Random.Range(2,5));
        }
        else if (other.gameObject.CompareTag("Ground"))
        {
            Debug.Log("viên ngọc vuông xanh đã va chạm với game object có nhãn ground");
            Destroy(gameObject);
            Debug.Log("đã xóa viên ngọc này");
        }

    }
}
