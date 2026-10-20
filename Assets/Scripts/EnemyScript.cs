using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    //TODO
    private GameManager gameManager;
    public void Initialize(GameManager manager)
    {
        gameManager = manager;
    } 
    

        private void OnMouseDown()
    {
        Debug.Log("Hola");

     gameManager.EnemigoDestruido(gameObject);

        Destroy(gameObject);    
    }
} 