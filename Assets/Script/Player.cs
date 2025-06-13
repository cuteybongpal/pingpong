using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        rb.linearVelocityY = 0;
        if (Input.GetKey(KeyCode.W))
        {
            rb.linearVelocityY = speed;

        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.linearVelocityY = -speed;

        }
    }
}
