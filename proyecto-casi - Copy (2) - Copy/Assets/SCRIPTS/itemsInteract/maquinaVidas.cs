using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maquinaVidas : Interactable
{
    public override void interact(){
        if (GameManager.instance.coins>0 && GameManager.instance.playerLife != GameManager.instance.maxPlayerLife){
            GameManager.instance.coins --;
            GameManager.instance.playerLife = GameManager.instance.maxPlayerLife;
        }
    }
}
