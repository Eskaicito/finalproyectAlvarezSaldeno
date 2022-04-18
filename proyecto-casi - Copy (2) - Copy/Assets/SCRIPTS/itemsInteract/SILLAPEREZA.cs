using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SILLAPEREZA : Interactable
{
  
    public override void interact()
    {
        animacionSentado();
        //posicion para que quede sentado blabla
        PecadosSingleton.instance.pecadoPereza = true;
    }

    private void animacionSentado()
    {
        
    }
}
