using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDamage : MonoBehaviour
{
    [SerializeField] int life = 100;
    private int dañoBala = 20;
    void Update()
    {
        if (life < 1)
        {  
            GameManager.instance.coins++;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("playerAttack"))
        {
            life -= dañoBala;
        }
    }
}
