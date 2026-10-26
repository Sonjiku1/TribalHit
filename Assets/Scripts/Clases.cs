using JetBrains.Annotations;
using System;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.Video;

public class Clases : MonoBehaviour { }
      public class Orco
  
{
    public string name;
    public float fuerza;
    public  float resistencia;
    public  float destreza;
    public  float vida;
    private object objetivo;

    public Orco(string n)
    {
        name = "fulanito";
        fuerza = 5.0f;
        resistencia = 5.0f;
        destreza = 5.0f;

        vida = 100 + resistencia * 5;
    }

    public void Atacar (Orco Objeto)
    {
        float daño = CalcularDañoBasico();
        object resultadoDaño = objetivo.CalcularDaño(daño);
        Debug.Log( $(nombre)"atacar a"(Objeto.nombre) "e inflige"(daño) "de daño.");


    }


    private float CalcularDañoBasico()
    {
        throw new NotImplementedException();
    }


    public void setVida(float vida)
    {
       // this.vida = Mathf.Clamp(vida,)
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
