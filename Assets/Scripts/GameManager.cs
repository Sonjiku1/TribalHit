using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //TODO

    // Prefab del enemigo que vamos a generar
    // exponerlo en el editor para poder asignarlo desde Unity

  [SerializeField] private  GameObject enemyPrefab;



    // ARRAY:
    // Las posiciones posibles son conocidas y no cambiarán
    // durante la ejecución del juego.

    // Número de enemigos que queremos generar en cada ronda

    // LIST:
    // El número de enemigos vivos sí cambiará durante la partida.
    GameObject createdEnemy;

    public int V { get; private set; }

    //Score
    void Start()
    {
        //TODO: Llamamos a la generación de enemigos

        //instanciar un enemigo 

       createdEnemy= Instantiate(enemyPrefab, Vector3.zero, Quaternion.identity); 

        // Que se desplace 3 unidades en el eje x 

       
    }

    void Update()
    {
        //TODO:  Reiniciamos la ronda pulsando R
        createdEnemy.transform.position += new Vector3(3.0f, 0f, 0f) *Time.deltaTime;

        // que no se salga de la pantalla x 10.85 y y 0.92

        if (createdEnemy.transform.position.x > 10.85f)
        {
            createdEnemy.transform.position = new Vector3(0, createdEnemy.transform.position.y, createdEnemy.transform.position.z);
        }

        // darle velocidad rapida al enemigo

float speed = 10.0f; // velocidad en unidades por segundo
        createdEnemy.transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);




    }

    //Generar oleada
    private void GenerarEnemigos()
    {
        //TODO: 
        // Evitamos intentar generar más enemigos
        // que posiciones disponibles.
        
        // ARRAY auxiliar:
        // Nos permite saber qué posiciones ya hemos utilizado.
        //
        // false = libre
        // true = ocupada

        // FOR:
        // Sabemos cuántos enemigos queremos generar.
        
            // Elegimos una posición aleatoria.

            // WHILE:
            // Mientras esa posición ya esté ocupada,
            // buscamos otra.
           
            // Marcamos esa posición como utilizada.

            // Creamos el enemigo.

            // Guardamos el enemigo en nuestra lista
            // de enemigos actualmente vivos.

            // Le damos al enemigo una referencia
            // al GameManager.
    }


    //Si se destruye un enemigo, incrementamos el score

    public void EnemigoDestruido(GameObject enemy)
    {
        //TODO: 
        // Eliminamos la referencia de la lista.
        // Cuando la lista esté vacía,
        // hemos terminado la ronda.
        
    }


    //Reiniciar la ronda

    private void ReiniciarEnemigos()
    {
        //TODO: 
        // Primero eliminamos cualquier enemigo
        // que todavía esté vivo.

        // Generamos una nueva oleada.
    }

    // Elminar a todos los enemigos
    private void EliminarEnemigos()
    {
        //TODO: 
        // FOREACH:
        // Queremos hacer la misma operación
        // con todos los enemigos de la lista.

        // Dejamos vacía la lista.

    }
}