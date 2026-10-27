using System.Numerics;
using UnityEngine;

public class Myvector3
{
    private float valorX;
   private float valorY;
   private float valorZ;
   private float magnitude;


    //constructor 

    public Myvector3()
    {
        valorX = 0;
        valorY = 0;
        valorZ = 0;
        this.magnitude = Magnitude();
    }

    public Myvector3 (float x, float y, float z,)
    {
        this.valorX = x;
        this.valorY = y;
        this .valorZ = z;

    }

  public  float Magnitude()
    {
        if ( magnitude > 0f)
        {
            return this.magnitude;
        } 
        else
        {
            this.magnitude = Mathf.Sqrt(valorX * valorX + valorY * valorY + valorZ * valorZ);
            return magnitude;

        }
    }

    public Myvector3 Add(Myvector3 vec)
    {
        float x3 = this.valorX + vec.valorX;
        float y3 = this.valorY + vec.valorY;
        float z3 = this.valorZ + vec.valorZ;

        Myvector3 vec3 = new Myvector3(x3,y3,z3);

        return new Myvector3(x3, y3, z3);

    }

    // public void Normalize()

}
