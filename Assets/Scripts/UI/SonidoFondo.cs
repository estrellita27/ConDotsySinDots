using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoFondo : MonoBehaviour
{
    private SonidoFondo instance;
    public SonidoFondo Instance{

        get{
            return instance;
        }
    }

    public void Awake(){

        if(FindObjectsOfType(GetType()).Length > 1){

            Destroy(gameObject);
        }

        if(instance!= null && instance!= this){
            Destroy(gameObject);
            return;
        }
        else{

            instance = this; 
        }

        DontDestroyOnLoad(gameObject);
    }
}
