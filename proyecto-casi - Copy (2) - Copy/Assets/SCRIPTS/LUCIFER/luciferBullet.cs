using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luciferBullet : MonoBehaviour
{
    [SerializeField] luciferData luciferData;
    void Start()
    { 
        Destroy(gameObject, luciferData.lifebullet);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward *Time.deltaTime * luciferData.bulletSpeed);
    }
    private void OnCollisionEnter(Collision other) {
        //Destroy(gameObject);
    }
}
