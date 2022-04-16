using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class barraVida : MonoBehaviour
{
   
   public Image barraDeVida;
   [SerializeField] float vidaMaxima;
   [SerializeField] float vidaActual;

    private void Start() {
        vidaMaxima = GameManager.instance.maxPlayerLife;
    }
    void Update()
    {
        vidaActual = GameManager.instance.playerLife;
        barraDeVida.fillAmount = vidaActual / vidaMaxima;
    }
}
