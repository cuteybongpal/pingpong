using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector2 Velocity;
    public float Speed;
    Rigidbody2D rb;

    public UI_Game Ui;
    void Start()
    {
        float velocityX = Random.Range(-1,1);
        float velocityY = Random.Range(-1, 1);

        rb = GetComponent<Rigidbody2D>();

        Velocity = new Vector2(velocityX, velocityY);
        Velocity = Velocity.normalized;
        Velocity *= Speed;

        rb.linearVelocity = Velocity;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wall"))
        {
            rb.linearVelocityY *= -1;
        }

        if (collision.CompareTag("Player"))
        {
            rb.linearVelocityX *= -1;
        }

        if (collision.CompareTag("DeadZone1"))
        {
            GameManager.Instance.score[1]++;
            Ui.ScoreChange(GameManager.Instance.score);
            StartCoroutine(CoRespawn());
        }

        if (collision.CompareTag("DeadZone2"))
        {
            GameManager.Instance.score[0]++;
            Ui.ScoreChange(GameManager.Instance.score);
            StartCoroutine(CoRespawn());
        }
    }
    IEnumerator CoRespawn()
    {
        transform.position = Vector3.zero;
        rb.linearVelocity = Vector3.zero;
        yield return new WaitForSeconds(2);

        float velocityX = Random.value;
        float velocityY = Random.value;

        Velocity = new Vector2(velocityX, velocityY);
        Velocity = Velocity.normalized;
        Velocity *= Speed;

        rb.linearVelocity = Velocity;
    }
}
