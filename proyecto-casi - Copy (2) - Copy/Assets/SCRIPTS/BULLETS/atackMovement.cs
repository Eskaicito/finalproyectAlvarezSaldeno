using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atackMovement : MonoBehaviour
{
    float speedBullet = 20.0f;

    //[SerializeField] float bulletDistance = 20f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveBullet();
        if (transform.localPosition.z > 8f)
        {

        }
    }

    private void moveBullet()
    {
        transform.Translate((speedBullet * Time.deltaTime * Vector3.forward.normalized));
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
    
}
