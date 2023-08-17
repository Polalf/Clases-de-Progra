using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Calculadora : MonoBehaviour
{
    public TMP_InputField Pantalla;
    public float numeroA,numeroB;
    public string simbolo;
    public float resultado;
    public bool numA;
    public float[] numeros;
    
    private void Start()
    {
        numA= true;
    }


    public void EscribirNum(int Num)
    {
        
        Pantalla.text += numeros[Num].ToString();
        
    }
    public void EscribirSim(string Sim)
    {
        if (numA)
        {
            numeroA += float.Parse(Pantalla.text);
            Pantalla.text = "";
        }
        

        simbolo = Sim; 
        Pantalla.text = " " + Sim.ToString();
        numA = false;
    }

    public void Operacion(string operacion)
    {
        if(!numA)
        {
            numeroB += float.Parse(Pantalla.text);
            Pantalla.text = "";
        }
        
        operacion = simbolo;
        if (operacion == "+")
        {
            resultado = numeroA + numeroB;
            Pantalla.text = " = " + resultado.ToString();
        }
        if (operacion == "-")
        {
            resultado = numeroA - numeroB;
            Pantalla.text = " = " + resultado.ToString();
        }
        if (operacion == "*")
        {
            resultado = numeroA * numeroB;
            Pantalla.text = " = " + resultado.ToString();
        }
        if (operacion == "/")
        {
            resultado = numeroA / numeroB;
            Pantalla.text = " = " + resultado.ToString();
        }

        
    }
    public void BorrarCaracter()
    {
        if (numA)
        {
            numeroA = 0;
            Pantalla.text = " ";
            numA = true;
        }
        else
        {
            numeroB = 0;
            Pantalla.text = " " ;
            numA= true;
        }
    }
    
    public void BorrarTodo()
    {
        numeroA = 0;
        numeroB = 0;
        resultado = 0;
        simbolo = null; 
        Pantalla.text = " ";
    }
}
