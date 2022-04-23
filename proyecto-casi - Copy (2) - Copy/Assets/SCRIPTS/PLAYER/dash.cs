using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dash : MonoBehaviour
{
    public bool isDashing = true;
    private float dashStartTime;
    private float timer = 0f;
    playerCharacter PlayerCharacter;
    CharacterController characterController;

    private void Start()
    {
        PlayerCharacter = GetComponent<playerCharacter>();
        characterController = GetComponent<CharacterController>();
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (PecadosSingleton.instance.pecadoLujuria == true){
        handleDash();
        while (isDashing){
            GameManager.instance.playerGolpeado = false;
        }
        }
    }
    private void handleDash()
    {
        bool isTryingToDash = Input.GetKeyDown(KeyCode.Q);
        if (isTryingToDash && !isDashing && timer >4f)
        {
            OnStartDash();
        }

        if (isDashing)
        {
            if (Time.time - dashStartTime <= 0.4f)
            {
                if (PlayerCharacter.directionPlayer.Equals(Vector3.zero))
                {
                    characterController.Move(transform.forward * 30f * Time.deltaTime);
                }
                else
                {
                    characterController.Move((transform.TransformDirection(PlayerCharacter.directionPlayer)) * 30f * Time.deltaTime);
                }
            } else{
                OnEndDash();
            }
        }
    }

    void OnStartDash()
    {
        isDashing = true;
        dashStartTime = Time.time;
    }

    void OnEndDash()
    {
        timer = 0f;
        isDashing = false;
        dashStartTime = 0;
    }

}
