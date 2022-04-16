using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Shootpoint : MonoBehaviour
{
    [SerializeField] GameObject shutpointh;
    [SerializeField] float distanceRay = 4f;
    void Update()
    {
        emitirRaycast();
    }

    private void emitirRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(shutpointh.transform.position, shutpointh.transform.TransformDirection(Vector3.forward), out hit, distanceRay))
        {
            if (hit.transform.tag == "item")
            {
                if (Input.GetKeyDown(KeyCode.G))
                {
                    hit.collider.transform.GetComponent<Interactable>().interact();
                }
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
