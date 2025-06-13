using UnityEngine;

public class Player1 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.linearVelocityY = speed;

        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.linearVelocityY = -speed;

        }
    }
}
