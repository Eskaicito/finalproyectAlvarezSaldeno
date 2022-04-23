using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireTorreta2 : MonoBehaviour
{
       [SerializeField] public GameObject bala;
    private void Start() {
        FindObjectOfType<lucifer>().startShoot2 += torretActive2;
    }
    void torretActive2(){
        Debug.Log("pium pium");
        Instantiate(bala, transform.position, transform.rotation);
    }
    
}
