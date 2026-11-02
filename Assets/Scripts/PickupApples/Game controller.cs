

using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Gamecontroller : MonoBehaviour
{
    [SerializeField] private GameObject applePrefab;
    [SerializeField] private float Gravity = 3f;

    [SerializeField] private Transform playerPosition;
    [SerializeField] private TMP_Text ScoreText;

    private List<GameObject> appleList = new List<GameObject>();

    private float timer;
    private int score;

    void Start()
    {
        timer = 0f;
        score = 0;

        // Comprobar referencias
        if (applePrefab == null)
        {
            Debug.LogError("Falta asignar Apple Prefab");
            enabled = false;
            return;
        }

        if (playerPosition == null)
        {
            Debug.LogError("Falta asignar Player Position");
            enabled = false;
            return;
        }

        if (ScoreText == null)
        {
            Debug.LogError("Falta asignar Score Text");
            enabled = false;
            return;
        }

        ScoreText.text = "Puntuación: " + score;
    }

    void Update()
    {
        timer += Time.deltaTime;

        // Crear una manzana cada 2 segundos
        if (timer >= 2f)
        {
            timer = 0f;

            GameObject newApple = Instantiate(applePrefab);

            newApple.transform.position = new Vector3(
                Random.Range(-3.5f, 3.5f),
                5.5f,
                0f
            );

            appleList.Add(newApple);
        }

        List<GameObject> appleListToRemove = new List<GameObject>();

        // Hacer caer las manzanas
        foreach (GameObject apple in appleList)
        {
            apple.transform.Translate(
                Vector3.down * Gravity * Time.deltaTime,
                Space.World
            );

            // Comprobar si toca al jugador
            float distance = Vector3.Distance(
                apple.transform.position,
                playerPosition.position
            );

            if (distance < 0.5f)
            {
                score++;

                ScoreText.text = "Puntuación: " + score;

                appleListToRemove.Add(apple);
            }
            // Eliminar manzanas fuera de la pantalla
            else if (apple.transform.position.y < -6f)
            {
                appleListToRemove.Add(apple);
            }
        }

        // Destruir las manzanas
        foreach (GameObject apple in appleListToRemove)
        {
            appleList.Remove(apple);
            Destroy(apple);
        }
    }
}
