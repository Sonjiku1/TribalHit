using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class Gamecontroller : MonoBehaviour
{
    [SerializeField] private GameObject applePrefab;
    [SerializeField] private float Gravity;
    List<GameObject> appleList = new List<GameObject>();
    [SerializeField] private Transform playerPosition;
    [SerializeField] private TMP_Text ScoreText;
   private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 0f;
        ScoreText.text 
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2f)
        {
            //se ha completado el timer
            //Reseteamos
            timer = 0f;

            //creamos una manzana

            GameObject newApple = Instantiate(applePrefab);

            newApple.transform.position = new Vector3(Random.Range(-3.5f, 3.5f), 5.5f);

            appleList.Add(newApple);

          
        }
        List<GameObject> appleListToRemove = new List<GameObject>;

       foreach (GameObject apple in appleList)
        {
            apple.transform.position += Vector3.down * Gravity * Time.deltaTime;
        }

        foreach (GameObject apple in appleList)
        {
            float distance = Vector3.Distance(apple.transform.position, playerTransform.position);
            if (distance < 0.5f)
            {
                Debug.Log("colision con manzana");
                appleListToRemove.Add(apple);
            }
     
        }

        foreach (GameObject apple in appleList)
        {
            appleList.Remove(apple);
            Destroy(apple);

        }
    }


}
