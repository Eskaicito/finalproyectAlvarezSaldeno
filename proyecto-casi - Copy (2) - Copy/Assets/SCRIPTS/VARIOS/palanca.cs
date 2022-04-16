using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palanca : Interactable
{
    // Start is called before the first frame update
    [SerializeField] GameObject reja;
    [SerializeField] GameObject paloPalanca;
    private bool canUse = true;

    public override void interact()
    { 
        if (canUse == true){
            Debug.Log("golpeado");
            paloPalanca.transform.position += new Vector3(1.2f, 0f, 0f);
            Destroy(reja);
            canUse = false;
            }
    }
}
