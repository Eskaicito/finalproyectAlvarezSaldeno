using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMecanicas : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    [SerializeField] float speedLook = 2f;
    [SerializeField] GameObject player;
    [SerializeField] GameObject bulletEnemy;
    [SerializeField] bool enemyIsAtacking = false;
    [SerializeField] private Animator enemyAnimator;
    private float temporizador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            temporizador += Time.deltaTime;
            followPlayer();
    }

    public void lookPlayer(){
        Quaternion newRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, speedLook*Time.deltaTime);
        enemyAnimator.SetBool("spiderIdle", true);
        
    }

    public void followPlayer()
    {
        Vector3 direction = (player.transform.position - transform.position);
        if (GameManager.instance.itsClose == true){ 
        if (direction.magnitude > 3)
        {
            lookPlayer();
            transform.position += speed * Time.deltaTime * direction.normalized;
            enemyAnimator.SetBool("spiderRun", true);
            
        }
        else{
            if (temporizador >= 2){
            enemyIsAtacking = true;
            Invoke("enemyAttack", 0f);
            temporizador = 0;
            enemyIsAtacking = false;
            }
        }
        }
    }

    private void enemyAttack(){
        Instantiate(bulletEnemy, transform);
    }
}