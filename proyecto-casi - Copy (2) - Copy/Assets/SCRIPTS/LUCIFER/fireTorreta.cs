using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireTorreta : MonoBehaviour
{
    [SerializeField] public GameObject bala;
    private void Start() {
        FindObjectOfType<lucifer>().startShoot += torretActive;
    }
    void torretActive(){
        Debug.Log("pium pium");
        Instantiate(bala, transform.position, transform.rotation);
    }
}
