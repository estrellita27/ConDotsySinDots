using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GestorDatosA : MonoBehaviour
{
    public Ejercito ejercito;
    
    public static GestorDatosA instanceA;

    private void Awake(){

        if(instanceA == null){

            instanceA = this;
            DontDestroyOnLoad(instanceA);

        }else{

            if(instanceA != this){
                Destroy(instanceA);
            }
        }
    }

    public static GestorDatosA InstanceA{
        get{ return instanceA; }
    }

    public void SetDatosA(Ejercito datosEjercito)
    {
        ejercito = datosEjercito;
    }

    public ScriptableObject GetDatosA()
    {
        return ejercito;
    }

}
