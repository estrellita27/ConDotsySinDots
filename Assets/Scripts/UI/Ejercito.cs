using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Ejercito", menuName = "Ejercito")]
public class Ejercito : ScriptableObject
{
    // Start is called before the first frame updatepublic string ejercito;
    public string ejercito;
    public int Cantidad = 0;
    public int Vida = 0;
    public int Fuerza = 0;
    public int Velocidad = 0;

    public string Descripcion;
    public Sprite Modelo;


    public void setEjercito(string ejercito){
        this.ejercito = ejercito;
    }

    public void setCantidad(int cantidad){
        this.Cantidad = cantidad;
    }

    public void setVida(int vida){
        this.Vida = vida;
    }

    public void setFuerza(int fuerza){
        this.Fuerza = fuerza;
    }

    public void setVelocidad(int velocidad){
        this.Velocidad = velocidad;
    }

    public void setDescripcion(string descripcion){
        this.Descripcion = descripcion;
    }

    public void setModelo(Sprite modelo){
        this.Modelo = modelo;
    }

    public string getEjercito(){
        return ejercito;
    }

    public int getCantidad(){
        return Cantidad;
    }

    public int getVida(){
        return Vida;
    }


    public int getFuerza(){
        return Fuerza;
    }

    public int getVelocidad(){
        return Velocidad;
    }

    public string getDescripcion(){
        return Descripcion;
    }

    public Sprite getModelo(){
        return Modelo;
    }
}
