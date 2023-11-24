using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PanelRomano : MonoBehaviour
{
    public Ejercito Romano;
    public Ejercito Alien;

    public TMP_InputField inCantidad;
    public TMP_InputField inVida;
    public TMP_InputField inFuerza;
    public TMP_InputField inVelocidad;
    
    private int cantidadRomano1;
    private int vidaRomano1;
    private int fuerzaRomano1;
    private int velocidadRomano1;

    public void inputCantidad(){
        cantidadRomano1 = Convert.ToInt32(inCantidad.text);
        Romano.setCantidad(cantidadRomano1);
    }
    
    public void inputVida(){
        vidaRomano1 = Convert.ToInt32(inVida.text);
        Romano.setVida(vidaRomano1);
    }

    public void inputFuerza(){
        fuerzaRomano1 = Convert.ToInt32(inFuerza.text);
        Romano.setFuerza(fuerzaRomano1);
    }

    public void inputVelocidad(){
        velocidadRomano1 = Convert.ToInt32(inVelocidad.text);
        Romano.setVelocidad(velocidadRomano1);
    }
    

    public void Siguiente_2(){

        GestorDatosR.InstanceR.SetDatosR(Romano);

         if(Romano.getCantidad() != 0 && Alien.getCantidad() != 0){
            SceneManager.LoadScene("PantallaCarga");
        }else if(Romano.getCantidad() == 0 || Alien.getCantidad() == 0){
            SceneManager.LoadScene("PantallaSelect2");
        }

       
    }   
}
