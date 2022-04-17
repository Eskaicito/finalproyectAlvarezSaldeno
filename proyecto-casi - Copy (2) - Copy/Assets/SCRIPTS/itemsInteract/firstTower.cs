using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstTower : Interactable
{
    public PecadosSingleton pecados;
    public override void interact()
    {
        if(gameObject.name== "PECADOGULA"){
            Destroy(gameObject);
            pecados.pecadoGula = true;
        }
    }
}
