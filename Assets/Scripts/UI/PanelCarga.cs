using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PanelCarga : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI valueProgreso;
    [SerializeField] Slider slider;

    private void Update(){
        if(Input.anyKey){
            StartCoroutine(Carga());
        }
    }

    private IEnumerator Carga(){
        slider.gameObject.SetActive(true);
        AsyncOperation operacionCarga = SceneManager.LoadSceneAsync("Final");

        while (operacionCarga.isDone == false){
            float progreso = Mathf.Clamp01(operacionCarga.progress / .09f);
            slider.value = progreso;
            valueProgreso.text = "" + progreso * 100 + "%";
            yield return null;
        }
    }

}
