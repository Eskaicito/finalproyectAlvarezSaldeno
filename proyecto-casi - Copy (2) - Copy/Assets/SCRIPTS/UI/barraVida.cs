using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class barraVida : MonoBehaviour
{
    public Image barraDeVida;
    public Image barraDeVidaGrande;
    [SerializeField] float vidaMaxima;
    [SerializeField] float vidaActual;
    public bool actualizarLife = true;

    private void Start()
    {
        
    }
    void Update()
    {
        if (PecadosSingleton.instance.pecadoGula == true && actualizarLife == true){
            GameManager.instance.maxPlayerLife = 200f;
            vidaMaxima = GameManager.instance.maxPlayerLife;
            Destroy(barraDeVida.gameObject);
            barraDeVidaGrande.gameObject.SetActive(true);
            GameManager.instance.playerLife = GameManager.instance.maxPlayerLife;
            actualizarLife = false;
        }
        
        if (PecadosSingleton.instance.pecadoGula == true)
        {
            vidaActual = GameManager.instance.playerLife;
            barraDeVidaGrande.fillAmount = vidaActual / vidaMaxima;
        }
        else
        {
            vidaActual = GameManager.instance.playerLife;
            barraDeVida.fillAmount = vidaActual / vidaMaxima;
        }
    }
}
