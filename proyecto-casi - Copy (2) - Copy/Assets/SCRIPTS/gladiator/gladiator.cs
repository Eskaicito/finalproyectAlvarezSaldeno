using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gladiator : enemigosPadre

{
    [SerializeField] Animator enemyAnimator;
    public override void animacionAtacar(){
        enemyAnimator.SetBool("IsAttack", true);
        enemyAnimator.SetBool("IsWalk", false);
    }
    public override void animacionCaminar(){
        enemyAnimator.SetBool("IsWalk", true);
        enemyAnimator.SetBool("IsAttack", false);
        
    }
    
}
