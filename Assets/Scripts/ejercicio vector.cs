using System.Numerics;
using UnityEngine;

public class ejerciciovector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // calcular la ddistancia entre modulos y su magnitud x1,y1 <x2,y2>


    float x1 = 3.0f;
    float y1 = 4.0f;

    float x2 = 7.0f;
    float y2 = 1.0f;

        // Calcular la magnitud (módulo) usando la fórmula de la raíz cuadrada de la suma de los cuadrados de sus componentes:

        float magnituddistancia = Mathf.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        Debug.Log("La magnitud de la distancia entre los puntos A(" + x1 + ", " + y1 + ") y B(" + x2 + ", " + y2 + ") es: " + magnituddistancia);


        return;



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
