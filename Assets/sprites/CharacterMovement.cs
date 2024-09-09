using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpHeigh = 5.0f;
    public int maxJump = 2;
    private int currentJump = 0;
    private Animator animator;
    public void AddSpeed(int amount)
    {
        speed += amount;
        StartCoroutine(DownSpeed(amount));
    }
    IEnumerator DownSpeed(int amount)
    {
        float time = 2;
        float downSpeedpersecond = amount/time;
        while (time > 0)
        {
            yield return new WaitForSeconds(1); 
            speed -= downSpeedpersecond;
            time--;
        }
    }

    void Start()
    {
        animator = GetComponent<Animator>(); //bắt đầu animation khép mở chân
    }
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        bool isMoving = moveHorizontal != 0; // khai báo biến isMoving
        animator.SetBool("isMoving", isMoving);

        if (isMoving) // nếu nhân vật đang di chuyển
        {
            transform.position += new Vector3(moveHorizontal * speed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (currentJump  >= maxJump) return;
            currentJump++;
            gameObject.GetComponent<Rigidbody2D>().velocity +=
            new Vector2(0, jumpHeigh);
        }       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            currentJump = 0;
        }
    }
}

