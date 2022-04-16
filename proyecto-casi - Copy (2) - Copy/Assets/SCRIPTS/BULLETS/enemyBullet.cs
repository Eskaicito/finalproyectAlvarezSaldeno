using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    float speedBullet = 20.0f;
    public Vector3 direccion;

    //[SerializeField] float bulletDistance = 20f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movePlayer(direccion);
        if (transform.localPosition.z > 3f)
        {
            
            Destroy(gameObject);
        }
    }

    private void movePlayer(Vector3 direccion)
    {
        transform.Translate(speedBullet * Time.deltaTime * direccion);
    }
}
