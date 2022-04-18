using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generadorControler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float temporizador1 = 0;
    [SerializeField] float temporizador2 = 0;
    [SerializeField] private Animator playerAnimator;
    [SerializeField] GameObject player;
    
     private void Awake() {
      //  FindObjectOfType<GameManager>().OnDeath+= muerto;
    }
    void Update()
    {
        temporizador1 += Time.deltaTime;
        temporizador2 += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Mouse0) && temporizador1 >= 2)
        {
            playerAnimator.SetBool("IsAttacking", true);
            Invoke("spawnbullet", 0f);
            temporizador1 = 0;
            
        }
        if(Input.GetKeyUp(KeyCode.Mouse0)){
            playerAnimator.SetBool("IsAttacking", false);
        }
         if (Input.GetKeyDown(KeyCode.E) && temporizador2 >= 4)
        {
            playerAnimator.SetBool("IsAttacking", true);
            //especialAttack();
            temporizador2 = 0;   
        }
    }

    private void spawnbullet()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
    /*private void especialAttack(){
        Invoke("spawnbullet", 0f);
        Invoke("spawnbullet", 0.1f);
        Invoke("spawnbullet", 0.2f);
        Invoke("spawnbullet", 0.3f);
        Invoke("spawnbullet", 0.4f);
        playerAnimator.SetBool("IsAttacking", false);
    }
   private void muerto(){
        Destroy(this);
    }
    */
}
