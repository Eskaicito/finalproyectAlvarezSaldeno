using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniSpider : enemigosPadre
{
    [SerializeField] private Animator enemyAnimator;
    [SerializeField] GameObject bulletEnemy;

   /* public override void animacionCaminar(){
        enemyAnimator = GetComponent<Animator>();
        enemyAnimator.SetBool("spiderRun", true);
        enemyAnimator.SetBool("spiderIdle", false);
        
    }
     public override void animacionAtacar(){
        enemyAttack();
        enemyAnimator = GetComponent<Animator>();
        enemyAnimator.SetBool("spiderIdle", true);
        enemyAnimator.SetBool("spiderRun", false);
    }
    
    private void enemyAttack(){
        Instantiate(bulletEnemy, transform);
    }
    */
}
