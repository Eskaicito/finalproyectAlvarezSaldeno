using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour

{
    private AudioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void fireAttack(){
        audioManager.seleccionAudio(3,0.5f);
    }
}
