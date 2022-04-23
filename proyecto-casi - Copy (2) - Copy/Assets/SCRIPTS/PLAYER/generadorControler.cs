using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generadorControler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float temporizador2 = 0;
    [SerializeField] private Animator playerAnimator;
    [SerializeField] GameObject player;

    void Update()
    {
        temporizador2 += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            playerAnimator.SetBool("IsAttacking", true);
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            playerAnimator.SetBool("IsAttacking", false);
        }
        if (Input.GetKeyDown(KeyCode.E) && temporizador2 >= 4 && PecadosSingleton.instance.pecadoIra)
        {
            Invoke("spawnbullet", 0f);
            //playerAnimator.SetBool("IsAttacking", true);
            //especialAttack();
            temporizador2 = 0;
        }
    }

    private void spawnbullet()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
}
