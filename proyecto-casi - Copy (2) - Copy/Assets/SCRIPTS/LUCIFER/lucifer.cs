using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lucifer : MonoBehaviour
{
    [SerializeField] luciferData luciferData;
    public event Action startShoot;
    public event Action startShoot2;
    private bool isOnCombat = false;
    private void Start()
    {
        luciferData.luciferMaxLife = 2000;
        luciferData.luciferLife = luciferData.luciferMaxLife;
        isOnCombat = false;
        //luciferData.bolaFuego1 = transform.Find("lanzaBolas1").gameObject;
        luciferData.bolaFuego2 = transform.Find("lanzaBolas2").gameObject;
        luciferData.player = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        lookTo();
        distanciaPlayer();
        luciferAtaque();
    }
    void distanciaPlayer()
    {
        Vector3 direction = (luciferData.player.transform.position - transform.position);
        luciferData.distanciaPlayer = direction.magnitude;
    }

    private void lookTo()
    {
        Quaternion newRotation = Quaternion.LookRotation((luciferData.player.transform.position - transform.position));
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 1 * Time.deltaTime);
    }
    private void luciferAtaque()
    {
        if (luciferData.distanciaPlayer < 100 && isOnCombat == false)
        {
            Debug.Log("en combate");
            StartCoroutine(torretasActivadas());
            isOnCombat = true;
        }
    }
    IEnumerator torretasActivadas()
    {
        while (luciferData.luciferLife > 1)
        {
            animacionAtaque();
            Debug.Log("torretas atacando");
            startShoot?.Invoke();
            if (luciferData.luciferLife < (luciferData.luciferMaxLife / 2))
            {
                startShoot2?.Invoke();
            }
            yield return new WaitForSeconds(luciferData.timerBalas);
        }
    }

    public virtual void animacionAtaque()
    {

    }
    private void OnParticleCollision(GameObject other) {
        if (other.transform.CompareTag("playerAttack")){
            luciferData.luciferLife -= GameManager.instance.flamethrowerDamage;
        }
    }
}
