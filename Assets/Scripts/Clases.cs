
using System;
using UnityEngine;

public class Clases : MonoBehaviour
{
}

public class Orco
{
    public string nombre;
    public float fuerza;
    public float resistencia;
    public float destreza;
    public float vida;

    public Orco(string n)
    {
        nombre = n;
        fuerza = 5.0f;
        resistencia = 5.0f;
        destreza = 5.0f;

        vida = 100 + resistencia * 5;
    }

    public void Atacar(Orco objetivo)
    {
        float daño = CalcularDañoBasico();

        objetivo.RecibirDaño(daño);

        Debug.Log(nombre + " ataca a " + objetivo.nombre +
                  " e inflige " + daño + " de daño.");
    }

    private float CalcularDañoBasico()
    {
        return fuerza * 2;
    }

    public void RecibirDaño(float daño)
    {
        setVida(vida - daño);
    }

    public void setVida(float nuevaVida)
    {
        vida = Mathf.Clamp(nuevaVida, 0, 100 + resistencia * 5);

        if (vida <= 0)
        {
            Debug.Log(nombre + " ha sido derrotado.");
        }
    }
}
