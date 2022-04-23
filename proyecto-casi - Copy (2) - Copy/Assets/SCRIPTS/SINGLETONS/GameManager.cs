using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int playerCoins;
    public float playerLife, maxPlayerLife, flamethrowerDamage;
    public bool playerGolpeado = false;
    
    public TextMeshProUGUI textGameOver;
    public TextMeshProUGUI dracmas;
    public GameObject player;
    public GameObject checkpoint;
    public int coins;
    public event Action OnDeath;
    
    public bool startAgain = true;
    public int escenaActiva = 1;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            playerLife = 100;
            maxPlayerLife = 100;
            playerCoins = 0;
            flamethrowerDamage = 5f;
            
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start() {
        checkpoint = FindObjectOfType<checkpoinManager>().gameObject;
    }
    private void Update() {
        dracmas.text = ""+coins;
        if (playerLife < 1){
            startAgain = true;
            playerLife = maxPlayerLife;
            StartCoroutine(death());
        }
    }
    IEnumerator death(){
        
        OnDeath?.Invoke();
        textGameOver.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(escenaActiva);
        textGameOver.gameObject.SetActive(false);
        player.transform.position = checkpoint.GetComponent<checkpoinManager>().actualCP;
    }
}
