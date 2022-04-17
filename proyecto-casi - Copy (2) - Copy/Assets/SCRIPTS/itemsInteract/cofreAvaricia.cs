using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cofreAvaricia : Interactable
{
   public override void interact()
    {
        PecadosSingleton.instance.pecadoGula = true;
        Destroy(gameObject);
    }
}
