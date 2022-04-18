using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESOROAVARICIA : Interactable
{
  
    public override void interact()
    {
        Destroy(gameObject);
        GameManager.instance.coins += 40;
        PecadosSingleton.instance.pecadoAvaricia = true;
    }
}
