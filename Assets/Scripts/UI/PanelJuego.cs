using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PanelJuego : MonoBehaviour
{
    public Ejercito Romano;
    public Ejercito Alien;


    public TMP_Text CantidadRomano;
    private int CantidadR;

    public TMP_Text CantidadAlien;
    private int CantidadA;

    void Start(){
        CantidadR = Romano.getCantidad();
        CantidadA = Alien.getCantidad();

        UpdateCantidad();
    }


    void UpdateCantidad(){
        CantidadRomano.text = CantidadR.ToString();
        CantidadAlien.text = CantidadA.ToString();
    }
 
}
