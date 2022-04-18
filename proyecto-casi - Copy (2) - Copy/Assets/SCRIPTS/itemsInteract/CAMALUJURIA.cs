using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMALUJURIA : Interactable
{
  
    public override void interact()
    {
        generarCorazonesAudio();
        PecadosSingleton.instance.pecadoLujuria = true;
    }

    private void generarCorazonesAudio()
    {
        
    }
}
