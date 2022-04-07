//2. Crear las variables necesarias para ingresar por Inspector
//el precio de 3 productos y un monto de dinero disponible.
//Comunicar si la suma de los mismos supera o no el monto de 
//dinero disponible.Luego indicar cuánto dinero sobra o falta.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ02 : MonoBehaviour
{
    public int precio1;
    public int precio2;
    public int precio3;
    public int dineroDisponible;

    void Start()
    {
        int total = precio1 + precio2 + precio3;
        if (total > dineroDisponible)
        {
            Debug.Log("No alcanza el dinero para comprar los tres productos, faltan $" + (total - dineroDisponible));
        }
        else if (total < dineroDisponible)
        {
            Debug.Log("El  dinero sobra para comprar los tres productos, sobran $" + (dineroDisponible - total));
        }
        else if (total == dineroDisponible)
        {
            Debug.Log("El dinero alcanza justo para comprar los tres productos, no sobra ni falta plata");
        }
    }

}//class
