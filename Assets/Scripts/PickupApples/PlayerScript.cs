
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    void Start()
    {
      
        // Posición inicial del jugador
        transform.position = new Vector3(0f, -4f, 0f);
    }

    void Update()
    {
        // Movimiento hacia la derecha
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        // Movimiento hacia la izquierda
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        // Limitar el movimiento horizontal
        float x = Mathf.Clamp(transform.position.x, -3.5f, 3.5f);

        transform.position = new Vector3(
            x,
            transform.position.y,
            transform.position.z
        );
    }
}
