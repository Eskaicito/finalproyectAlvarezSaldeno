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
    public float playerLife, maxPlayerLife;
    public bool itsClose;
    public TextMeshProUGUI textGameOver;
    public TextMeshProUGUI dracmas;
    public GameObject player;
    public GameObject checkpoint;
    public int coins;
    public event Action OnDeath;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            playerLife = 100;
            maxPlayerLife = 100;
            playerCoins = 0;
            itsClose = false;
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
            player.transform.position = new Vector3(100,100,100);
            playerLife = maxPlayerLife;
            StartCoroutine(death());
        }
    }
    IEnumerator death(){
        itsClose = false;
        OnDeath?.Invoke();
        textGameOver.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("ALCANTARILLAS");
        textGameOver.gameObject.SetActive(false);
        player.transform.position = checkpoint.GetComponent<checkpoinManager>().actualCP;
    }
}
