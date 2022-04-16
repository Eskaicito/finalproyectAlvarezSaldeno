using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstTower : Interactable
{
    public override void interact()
    {
        transform.position = new Vector3(2,2,2);
    }
}
