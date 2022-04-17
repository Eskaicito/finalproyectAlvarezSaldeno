using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cuadroTrigger : MonoBehaviour
{
    [SerializeField] public GameObject luciferVida;
    [SerializeField] GameObject bloqueoSalida;
    private void OnTriggerEnter(Collider other) {
        //luciferVida = GameObject.Find("GAMEMANAGER").transform.Find("HUD").transform.Find("Canvas").transform.Find("life_fondo");
        luciferVida = GameObject.Find("GAMEMANAGER").transform.Find("HUD").transform.Find("Canvas").transform.Find("luciferVida").gameObject;
        if (other.transform.CompareTag("Player")){
            luciferVida.gameObject.SetActive(true);
            bloqueoSalida.SetActive(true);
        }
    }
}
 