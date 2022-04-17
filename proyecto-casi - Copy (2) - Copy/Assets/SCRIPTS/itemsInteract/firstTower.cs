using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstTower : Interactable
{
    public override void interact()
    {
        PecadosSingleton.instance.pecadoGula = true;
        Destroy(gameObject);
    }
}
