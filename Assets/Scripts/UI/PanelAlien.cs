using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PanelAlien : MonoBehaviour
{
    public Ejercito Romano;
    public Ejercito Alien;
    public TMP_InputField inCantidad;
    public TMP_InputField inVida;
    public TMP_InputField inFuerza;
    public TMP_InputField inVelocidad;

    private int cantidadAlien1;
    private int vidaAlien1;
    private int fuerzaAlien1;
    private int velocidadAlien1;

    public void inputCantidad_1(){
        cantidadAlien1 = Convert.ToInt32(inCantidad.text);
        Alien.setCantidad(cantidadAlien1);
    }

    public void inputVida_1(){
        vidaAlien1 = Convert.ToInt32(inVida.text);
        Alien.setVida(vidaAlien1);
    }

    public void inputFuerza_1(){
        fuerzaAlien1 = Convert.ToInt32(inFuerza.text);
        Alien.setFuerza(fuerzaAlien1);
    }

    public void inputVelocidad_1(){
        velocidadAlien1 = Convert.ToInt32(inVelocidad.text);
        Alien.setVelocidad(velocidadAlien1);
    }

    public void Siguiente_3(){

        GestorDatosA.InstanceA.SetDatosA(Alien);

        if(Romano.getCantidad() != 0 && Alien.getCantidad() != 0){
            SceneManager.LoadScene("PantallaCarga");
        }else if(Romano.getCantidad() == 0 || Alien.getCantidad() == 0){
            SceneManager.LoadScene("PantallaSelect3");
        }
    }
}
