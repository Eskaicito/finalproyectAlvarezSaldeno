using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cuadroTrigger : MonoBehaviour
{
    [SerializeField] public GameObject luciferVida;
    [SerializeField] GameObject bloqueoSalida;
    [SerializeField] GameObject shutpointh;
    [SerializeField] float distanceRay = 4f;
    private void OnTriggerEnter(Collider other)
    {
        //luciferVida = GameObject.Find("GAMEMANAGER").transform.Find("HUD").transform.Find("Canvas").transform.Find("life_fondo");
        luciferVida = GameObject.Find("GAMEMANAGER").transform.Find("HUD").transform.Find("Canvas").transform.Find("luciferVida").gameObject;
        if (other.transform.CompareTag("Player"))
        {
            luciferVida.gameObject.SetActive(true);
            bloqueoSalida.SetActive(true);
            other.transform.localScale += new Vector3(3,3,3);
        }
    }

    private void emitirRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(shutpointh.transform.position, shutpointh.transform.TransformDirection(Vector3.forward), out hit, distanceRay))
        {
            if (hit.transform.tag == "Player")
            {
                PecadosSingleton.instance.pecadoSoberbia = true;
                hit.transform.localScale += new Vector3(3,3,3);
                luciferVida.gameObject.SetActive(true);
                bloqueoSalida.SetActive(true);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Vector3 puntob = shutpointh.transform.TransformDirection(Vector3.forward) * distanceRay;
        Gizmos.DrawRay(shutpointh.transform.position, puntob);
    }
}
