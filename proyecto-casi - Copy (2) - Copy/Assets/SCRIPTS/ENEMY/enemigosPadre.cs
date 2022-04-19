using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigosPadre : MonoBehaviour
{
    [SerializeField] enemyData enemyData;
    [SerializeField] lifeData lifeData;
    void Start()
    {
        lifeData.enemyLife = lifeData.maxEnemyLife;
        lifeData.persecucion = false;
        lifeData.actualEnemyLife = lifeData.enemyLife;
        enemyData.distanciaPlayer = 0;
        lifeData.playerDetectado = false;
        enemyData.player = GameObject.FindWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lifeData.enemyLife < 1){
            Destroy(gameObject);
        }
        if(enemyData.distanciaPlayer >=403){
            lifeData.persecucion = false;
            lifeData.playerDetectado = false;
        }
        if (lifeData.enemyLife < lifeData.actualEnemyLife)
        {
            lifeData.persecucion = true;
        }
        if (lifeData.persecucion == true)
        {
            enemyData.timer = 0;
            lifeData.timerOnOff = true;
            lifeData.playerDetectado = true;
            lifeData.actualEnemyLife = lifeData.enemyLife;
            lifeData.persecucion = false;
        }
        if (lifeData.timerOnOff == true)
        {
            enemyData.timer += Time.deltaTime;
            if (enemyData.timer > 8)
            {
                lifeData.timerOnOff = false;
                lifeData.playerDetectado = false;
                lifeData.persecucion = false;
            }
        }
        if (lifeData.playerDetectado == true)
        {
            lookTo();
            followA();
            if (enemyData.distanciaPlayer <= enemyData.DistanciaAtaqueEnemy)
            {
                enemyAtaca();
            }
            else{
                enemyNoAtaca();
            }

        }
        Vector3 direction = (enemyData.player.transform.position - transform.position);
        enemyData.distanciaPlayer = direction.magnitude;
    }

    public void enemyAtaca()
    {
        animacionAtacar();
    }
    public void enemyNoAtaca()
    {
        animacionNoAtacar();
    }

    public virtual void animacionAtacar()
    {
        Debug.Log("ATACANDO");
    }
    public virtual void animacionNoAtacar()
    {
        Debug.Log("NO ATACANDO");
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            lifeData.persecucion = true;
            Debug.Log("aa");
            lifeData.playerDetectado = true;
        }
    }

    void followA()
    {
        Vector3 direction = (enemyData.player.transform.position - transform.position);
        enemyData.distanciaPlayer = direction.magnitude;
        if (direction.magnitude > enemyData.DistanciaAtaqueEnemy)
        {
            animacionCaminar();
            transform.position += enemyData.Speed * Time.deltaTime * direction.normalized;
        }
    }

    private void lookTo()
    {
        Quaternion newRotation = Quaternion.LookRotation((enemyData.player.transform.position - transform.position));
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 1 * Time.deltaTime);
    }
    public virtual void animacionCaminar()
    {
        Debug.Log("caminando");
    }
    private void OnParticleCollision(GameObject other) {
        if (other.transform.CompareTag("playerAttack")){
            lifeData.enemyLife -= GameManager.instance.flamethrowerDamage;
        }
    }
}
