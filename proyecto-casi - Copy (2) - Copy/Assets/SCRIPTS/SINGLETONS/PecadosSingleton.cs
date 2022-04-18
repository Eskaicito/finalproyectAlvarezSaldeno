using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PecadosSingleton : MonoBehaviour
{
    public static PecadosSingleton instance;
    public bool pecadoSoberbia = false;
    public bool pecadoAvaricia = false;
    public bool pecadoLujuria = false;
    public bool pecadoIra = false;
    public bool pecadoGula = false;
    public bool pecadoEnvidia = false;
    public bool pecadoPereza = false;
    public bool playerPecador = false;
    [SerializeField] GameObject luzAvaricia;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        int countPS = FindObjectsOfType<checkpoinManager>().Length;
        if (countPS > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Update() {
        if (pecadoAvaricia == true){
            luzAvaricia.SetActive(true);
        }
        if (pecadoIra == true){
            //cambiar color de lanzallamas
            GameManager.instance.flamethrowerDamage = 300;
        }


        if (pecadoGula && pecadoAvaricia && pecadoLujuria && pecadoIra && pecadoPereza && pecadoEnvidia){
            playerPecador = true;
        }
    }
}
