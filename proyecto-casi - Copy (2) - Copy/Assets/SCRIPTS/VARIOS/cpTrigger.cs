using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cpTrigger : MonoBehaviour
{
    [SerializeField] Vector3 posishon;
    [SerializeField] GameObject checkpoint;
    private void Start() {
        checkpoint = FindObjectOfType<checkpoinManager>().gameObject;
        posishon = transform.position;
    }
   private void OnTriggerEnter(Collider other) {
       if (other.CompareTag("Player")){
           checkpoint.GetComponent<checkpoinManager>().actualCP = posishon;
           Debug.Log("NASHEI");
       }
   }
}
