using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockMinusMover : MonoBehaviour
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
            Debug.Log("viên ngọc vuông đỏ đã va chạm với game object có nhãn player");          
            FindObjectOfType<AudioManager>().PlayAudio(Audio);
            Destroy(gameObject);
            Debug.Log("đã xóa viên ngọc này ");
            FindObjectOfType<ScoreManager>().AddTimer(-3);
        }
        else if (other.gameObject.CompareTag("Ground"))
        {
            Debug.Log("viên ngọc vuông đỏ đã va chạm với game object có nhãn ground");
            Destroy(gameObject);
            Debug.Log("đã xóa viên ngọc này");
        }

    }
}
