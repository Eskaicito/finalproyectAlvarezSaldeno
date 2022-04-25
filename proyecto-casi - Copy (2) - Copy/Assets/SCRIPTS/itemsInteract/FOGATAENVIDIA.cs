using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOGATAENVIDIA : MonoBehaviour
{
    [SerializeField] public ParticleSystem fuego;
    [SerializeField] float VIDAFOGATA = 600F;
    private bool estaEncendida = false;
    private void OnParticleCollision(GameObject other)
    {
        if (other.transform.CompareTag("playerAttack"))
        {
            VIDAFOGATA -= GameManager.instance.flamethrowerDamage;
        }
    }
    private void Start()
    {
        fuego = transform.Find("FUEGO").gameObject.GetComponent<ParticleSystem>();
    }
    private void Update()
    {
        if (estaEncendida == false && VIDAFOGATA < 1f)
        {
            PecadosSingleton.instance.pecadoEnvidia = true;
            fuego.Play();
        }
    }
}
