
using UnityEngine;
using TMPro;
using System.Collections;

public class player2 : MonoBehaviour
{
    [SerializeField] private float speed;

    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;

    public TMP_Text scoreText;
    int score = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        scoreText.text = "Score: 0";
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        // Flip X según la dirección del movimiento
        if (horizontalInput > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (horizontalInput < 0)
        {
            spriteRenderer.flipX = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Si toca una fruta
        if (collision.gameObject.CompareTag("fruit"))
        {
            Debug.Log("Colisión con fruta");

            score++;
            scoreText.text = "Score: " + score;

            StartCoroutine(CambiarColor());

            Rigidbody2D fruitRb = collision.gameObject.GetComponent<Rigidbody2D>();

            if (fruitRb != null)
            {
                fruitRb.linearVelocity = new Vector2(0f, 10f);
            }
        }

        // Si toca al otro jugador
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(CambiarColor());
        }
    }

    IEnumerator CambiarColor()
    {
        spriteRenderer.color = Color.red;

        yield return new WaitForSeconds(1f);

        spriteRenderer.color = Color.white;
    }

    private void FixedUpdate()
    {
        rb.AddForce(Vector2.right * 9.81f * Time.deltaTime, ForceMode2D.Force);
    }
}
