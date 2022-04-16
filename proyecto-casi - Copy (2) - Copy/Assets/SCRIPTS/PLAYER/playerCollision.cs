using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollision : MonoBehaviour
{
    [SerializeField] GameObject checkpoint;
    [SerializeField] GameObject player;
    private int dañoBala = 20;
    // Start is called before the first frame update
    private void Awake()
    {
        checkpoint = FindObjectOfType<checkpoinManager>().gameObject;
        FindObjectOfType<GameManager>().OnDeath += muerto;
    }
    void Start()
    {
        Debug.Log("INICIO DE NUEVO"+ checkpoint.GetComponent<checkpoinManager>().actualCP);
        player.transform.position = checkpoint.GetComponent<checkpoinManager>().actualCP;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = checkpoint.GetComponent<checkpoinManager>().actualCP;
        /*if (GameManager.instance.playerLife < 1)
        {
            GameManager.instance.playerLife = 150;
            GameManager.instance.itsClose = false;
            SceneManager.LoadScene("ALCANTARILLAS");
        }
        */
        if (Input.GetKey(KeyCode.H))
        {
            transform.position = new Vector3(2, 2, -7);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemyAttack"))
        {
            GameManager.instance.playerLife -= dañoBala;
        }
        if (other.gameObject.CompareTag("JARDINPORTAL"))
        {
            checkpoint.GetComponent<checkpoinManager>().actualCP = new Vector3(5, 3, -18);
            SceneManager.LoadScene("ALCANTARILLAS");
        }
        if (other.gameObject.CompareTag("PORTAL2"))
        {

            SceneManager.LoadScene("LABERINTO-ARENA");
        }
        if (other.gameObject.CompareTag("checkPoint"))
        {
            GameManager.instance.itsClose = true;
        }
    }
    private void muerto()
    {
        Destroy(this);
    }
}
