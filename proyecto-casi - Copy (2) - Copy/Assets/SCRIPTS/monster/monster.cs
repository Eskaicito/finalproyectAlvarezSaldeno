using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : enemigosPadre
{
    [SerializeField] Animator enemyAnimator;
    public override void animacionAtacar(){
        enemyAnimator = GetComponent<Animator>();
        enemyAnimator.SetBool("IsAttack", true);
        enemyAnimator.SetBool("IsWalk", false);
    }
    public override void animacionCaminar(){
        enemyAnimator = GetComponent<Animator>();
        enemyAnimator.SetBool("IsWalk", true);
        enemyAnimator.SetBool("IsAttack", false);
        
    }
    public override void animacionNoAtacar(){
        enemyAnimator.SetBool("IsAttack", false);
    }
}
