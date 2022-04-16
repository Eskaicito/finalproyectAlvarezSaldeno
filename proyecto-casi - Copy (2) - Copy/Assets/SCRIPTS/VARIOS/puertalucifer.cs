using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertalucifer : MonoBehaviour
{
    [SerializeField] bool pecadoScript;
    private float timer;
   
    private void Start() {
        pecadoScript = FindObjectOfType<PecadosSingleton>().playerPecador;
        timer = 0;
    }
    void Update()
    {
        if (pecadoScript == true){
            while (timer < 6){
                timer += Time.deltaTime;
                transform.position += new Vector3(0, 5,0) * Time.deltaTime;
            }
        }
    }
}
