using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private GameManager gameManager;

    public void initialize(GameManager manager)
    {
        gameManager = manager;
    }


    public void OnMouseDown()
    {

    Debug.Log("Hola");

        GameManager.EnemigoDestruido(GameObject);

        Destroy(GameObject);
}

  }
  