//1.Crea un programa que permita ingresar por Inspector dos valores enteros y responda si son iguales o no lo son.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ01 : MonoBehaviour
{
    public int num1;
    public int num2;

    void Start()
    {
        if (num1 == num2)
        {
            Debug.Log(num1 + " y " + num2 + " son iguales");
        }
        else
        {
            Debug.Log(num1 + " y " + num2 + " no son iguales");
        }
    }

}//class
