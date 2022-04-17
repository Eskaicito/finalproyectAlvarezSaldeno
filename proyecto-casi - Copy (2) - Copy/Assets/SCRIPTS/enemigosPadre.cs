using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigosPadre : MonoBehaviour
{
     private AudioManager audioManager;
    [SerializeField] enemyData enemyData;
    void Start()
    {
        enemyData.persecucion = false;
        enemyData.actualEnemyLife = enemyData.enemyLife;
        enemyData.distanciaPlayer = 0;
        enemyData.playerDetectado = false;
        enemyData.player = GameObject.FindWithTag("Player");
    }
    private void Awake() {
        audioManager = FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyData.enemyLife < 1){
            Destroy(gameObject);
        }
        if(enemyData.distanciaPlayer >=403){
            enemyData.persecucion = false;
            enemyData.playerDetectado = false;
        }
        if (enemyData.enemyLife < enemyData.actualEnemyLife)
        {
            enemyData.persecucion = true;
        }
        if (enemyData.persecucion == true)
        {
            enemyData.timer = 0;
            enemyData.timerOnOff = true;
            enemyData.playerDetectado = true;
            enemyData.actualEnemyLife = enemyData.enemyLife;
            enemyData.persecucion = false;
        }
        if (enemyData.timerOnOff == true)
        {
            enemyData.timer += Time.deltaTime;
            if (enemyData.timer > 8)
            {
                enemyData.timerOnOff = false;
                enemyData.playerDetectado = false;
                enemyData.persecucion = false;
            }
        }
        if (enemyData.playerDetectado == true)
        {
            lookTo();
            followA();
            if (enemyData.distanciaPlayer <= enemyData.DistanciaAtaqueEnemy)
            {
                enemyAtaca();
            }

        }
        Vector3 direction = (enemyData.player.transform.position - transform.position);
        enemyData.distanciaPlayer = direction.magnitude;
    }

    public void enemyAtaca()
    {
        animacionAtacar();
    }

    public virtual void animacionAtacar()
    {
        Debug.Log("ATACANDO");
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            enemyData.persecucion = true;
            Debug.Log("aa");
            enemyData.playerDetectado = true;
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
}
