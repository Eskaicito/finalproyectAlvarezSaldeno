using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mesaGula : Interactable
{
    public override void interact()
    {
        PecadosSingleton.instance.pecadoGula = true;
    }
}

