using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlEscenas : MonoBehaviour
{
    public void Video(){
     SceneManager.LoadScene("PantallaVideo");
    }

    public void Romano(){
        SceneManager.LoadScene("PantallaRomano");
    }

    public void Alien(){
        SceneManager.LoadScene("PantallaAlien");
    }

    public void Select1(){
        SceneManager.LoadScene("PantallaSelect");
    }

    public void Select2(){
        SceneManager.LoadScene("PantallaSelect2");
    }

    public void Select3(){
        SceneManager.LoadScene("PantallaSelect3");
    }

    public void Principal(){
        SceneManager.LoadScene("PantallaPrincipal");
    }

    public void Salir(){
        Application.Quit();
    }
}