using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Selection : MonoBehaviour
{

    public Ejercito tipoEjercito;

    public TextMeshProUGUI ejercitotext;
    public TextMeshProUGUI descriptiontext;

    public Image modeloImage;


    void Start()
    {
        ejercitotext.text = tipoEjercito.ejercito;
        descriptiontext.text = tipoEjercito.Descripcion;

        modeloImage.sprite = tipoEjercito.Modelo;
    }

}
