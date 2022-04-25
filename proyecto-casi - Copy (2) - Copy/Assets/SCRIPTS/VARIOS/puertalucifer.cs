using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertalucifer : MonoBehaviour
{

    private bool yaSubio = false;

    private void Start()
    {
        yaSubio = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            if (PecadosSingleton.instance.playerPecador && yaSubio == false)
            {
                StartCoroutine(subir());
                yaSubio = true;
            }
        }
    }
    IEnumerator subir(){
        transform.position += new Vector3(0, 0.8f, 0);
        yield return new WaitForSeconds(0.3f);
        transform.position += new Vector3(0, 0.8f, 0);
        yield return new WaitForSeconds(0.3f);
        transform.position += new Vector3(0, 0.8f, 0);
        yield return new WaitForSeconds(0.3f);
        transform.position += new Vector3(0, 0.8f, 0);
        yield return new WaitForSeconds(0.3f);
    }
}
