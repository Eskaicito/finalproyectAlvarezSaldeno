using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollision : MonoBehaviour
{
    [SerializeField] GameObject checkpoint;
    [SerializeField] GameObject player;
    // Start is called before the first frame update
    private void Awake()
    {
        checkpoint = FindObjectOfType<checkpoinManager>().gameObject;
        FindObjectOfType<GameManager>().OnDeath += muerto;
    }
    void Start()
    {
        Debug.Log("INICIO DE NUEVO" + checkpoint.GetComponent<checkpoinManager>().actualCP);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.position = checkpoint.GetComponent<checkpoinManager>().actualCP;
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

        if (other.gameObject.CompareTag("enemyAttack") && GameManager.instance.playerGolpeado == true)
        {

            if (other.gameObject.name == "cajaDañoSpider")
            {
                GameManager.instance.playerLife -= GameObject.Find("MINISPIDER").GetComponent<enemigosPadre>().enemyData.EnemyDamage;
            }
            if (other.gameObject.name == "cajaDañoBigSpider")
            {
                GameManager.instance.playerLife -= GameObject.Find("BIGSPIDER").GetComponent<enemigosPadre>().enemyData.EnemyDamage;
            }
            if (other.gameObject.name == "cajaDañoGladiator")
            {
                GameManager.instance.playerLife -= GameObject.Find("GLADIATOR").GetComponent<enemigosPadre>().enemyData.EnemyDamage;
            }
            if (other.gameObject.name == "cajaDañoBigGladiator")
            {
                GameManager.instance.playerLife -= GameObject.Find("BIG GLADIATOR").GetComponent<enemigosPadre>().enemyData.EnemyDamage;
            }
            if (other.gameObject.name == "cajaDañoMonster")
            {
                GameManager.instance.playerLife -= GameObject.Find("MONSTER").GetComponent<enemigosPadre>().enemyData.EnemyDamage;
            }
        }
        
        if (other.gameObject.CompareTag("JARDINPORTAL"))
        {
            checkpoint.GetComponent<checkpoinManager>().actualCP = new Vector3(5, 3, -18);
            GameManager.instance.startAgain = true;
            GameManager.instance.escenaActiva = 2;
            SceneManager.LoadScene("ALCANTARILLAS");
        }
        if (other.gameObject.CompareTag("PORTAL2"))
        {
            checkpoint.GetComponent<checkpoinManager>().actualCP = new Vector3(-8.3f, -2.46f, -345f);
            GameManager.instance.startAgain = true;
            GameManager.instance.escenaActiva = 3;
            SceneManager.LoadScene("LABERINTO-ARENA");
        }
        if (other.gameObject.CompareTag("luciferBala")){
            GameManager.instance.playerLife -= 30;            
        }
    }
    private void muerto()
    {
        Destroy(this);
    }

}
