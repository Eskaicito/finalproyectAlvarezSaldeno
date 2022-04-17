using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstTower : Interactable
{
    [SerializeField] public int vidaCubito = 500;
    [SerializeField] public int dañofuegito = 1;
    public override void interact()
    {
        transform.position = new Vector3(2,2,2);
    }
    
    private void OnParticleCollision(GameObject other) {
        if (other.gameObject.CompareTag("fuego")){
            vidaCubito -= dañofuegito;
        }
    }
}