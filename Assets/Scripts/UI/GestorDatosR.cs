using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GestorDatosR : MonoBehaviour
{
    public Ejercito ejercito;
    
    public static GestorDatosR instanceR;

    private void Awake(){

        if(instanceR == null){

            instanceR = this;
            DontDestroyOnLoad(instanceR);

        }else{

            if(instanceR != this){
                Destroy(instanceR);
            }
        }
    }

    public static GestorDatosR InstanceR{
        get{ return instanceR; }
    }

    public void SetDatosR(Ejercito datosEjercito)
    {
        ejercito = datosEjercito;
    }

    public ScriptableObject GetDatosR()
    {
        return ejercito;
    }

}
