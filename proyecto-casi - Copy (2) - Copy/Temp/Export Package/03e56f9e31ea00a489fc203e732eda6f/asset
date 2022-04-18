using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class tutoriales : MonoBehaviour
{
    [SerializeField] Image fondo;
    
    [SerializeField] TextMeshProUGUI texto;
    [SerializeField] string blabla;
    private void Start()
    {
        fondo.gameObject.SetActive(false);
        texto.text = blabla;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            StartCoroutine(newText());
        }
    }

    IEnumerator newText()
    {
        fondo.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        fondo.gameObject.SetActive(false);
    }
}
