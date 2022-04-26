using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class tutoriales : MonoBehaviour
{
    [SerializeField] public mensajesData mensajesData;
    [SerializeField] Image fondo;
    
    [SerializeField] TextMeshProUGUI texto;
    
    
    
    private void Start()
    {
        fondo = GameObject.Find("GAMEMANAGER").transform.Find("HUD").transform.Find("Canvas").transform.Find("tutorialText").gameObject.GetComponent<Image>();
        texto = GameObject.Find("GAMEMANAGER").transform.Find("HUD").transform.Find("Canvas").transform.Find("tutorialText").transform.Find("textito").GetComponent<TextMeshProUGUI>();
        mensajesData.textOn = false;
        fondo.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && mensajesData.textOn == false){
            StartCoroutine(newText());
        }
    }

    IEnumerator newText()
    {
        texto.text = mensajesData.Blabla;
        mensajesData.textOn = true;
        fondo.gameObject.SetActive(true);
        yield return new WaitForSeconds(mensajesData.TimeWaiting);
        fondo.gameObject.SetActive(false);
        if(mensajesData.VuelveAparecer == true){
        mensajesData.textOn = false;
        }    
    }
}
