using System;
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

    // Hacer un array de transforms
    [SerializeField] private Transform[] spawnPositions;

    // Número de enemigos que queremos generar en cada ronda

    [ SerializeField] private int numberOfEnemies = 5;
    
    // LIST:
    // El número de enemigos vivos sí cambiará durante la partida.
    GameObject createdEnemy;

    private List<GameObject> activeEnemies = new List<GameObject>();
    public int V { get; private set; }

    //Score
  
     int score = 0;

    GameObject created;
    void Start()
    {
        //TODO: Llamamos a la generación de enemigos

        //instanciar un enemigo 

       createdEnemy= Instantiate(enemyPrefab, Vector3.zero, Quaternion.identity); 

        // Que se desplace 3 unidades en el eje x 


       
    }
    

    void Update()
    {
        // Reiniciamos la ronda pulsando R
        if (Input.GetKeyDown(KeyCode.R))
        {
            GenerarEnemigos(enemyPrefab);
        }

        createdEnemy.transform.position += new Vector3(3.0f, 0f, 0f) * Time.deltaTime;

        if (createdEnemy.transform.position.x > 10.85f)
        {
            createdEnemy.transform.position = new Vector3(0, createdEnemy.transform.position.y, createdEnemy.transform.position.z);
        }

        float speed = 10.0f; // velocidad en unidades por segundo
        createdEnemy.transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
    }
  

    //Generar oleada
    private void GenerarEnemigos(GameObject enemyPrefab)
    {
        if (numberOfEnemies > spawnPositions.Length)
        {
            Debug.LogWarning("No hay suficientes posiciones para generar enemigos.");
            return;
        }

        // Usar un bool[] explícito y con nombre distinto para evitar conflictos de scope
        bool[] ocupados = new bool[spawnPositions.Length];
        for (int i = 0; i < ocupados.Length; i++)
        {
            ocupados[i] = false;
        }
   
        // Generamos numberOfEnemies enemigos (sin punto y coma que vaciaba el for)
        for (int i = 0; i < numberOfEnemies; i++)
        {
            int randomposition = UnityEngine.Random.Range(0, spawnPositions.Length);

            // Mientras la posición esté ocupada, buscamos otra
            while (ocupados[randomposition])
            {
                randomposition = UnityEngine.Random.Range(0, spawnPositions.Length);
            }

            // Marcamos la posición usada
            ocupados[randomposition] = true;

            // Instanciamos el enemigo en la posición elegida y lo guardamos en la lista
            GameObject enemy = Instantiate(
            enemyPrefab,
            position: spawnPositions[randomposition].position,
            Quaternion.identity);


        activeEnemies.Add(enemy);
            
            


            EnemyScript enemyScript = enemy.GetComponent<EnemyScript>();


            // Si el prefab tiene un componente que necesita referencia al GameManager,


            // asignarla aquí (no se puede asumir el nombre del componente sin más contexto).
            // Ejemplo (descomentar si existe un componente EnemyScript con SetGameManager):
            // var enemyComp = enemy.GetComponent<EnemyScript>();
            // if (enemyComp != null) enemyComp.SetGameManager(this);
        }
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