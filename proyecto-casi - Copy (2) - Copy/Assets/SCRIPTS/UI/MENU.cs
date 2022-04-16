using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MENU : MonoBehaviour
{
    [SerializeField] GameObject fondoNegro;
    private bool imagen;

    private void Start() {
        fondoNegro.SetActive(false);
    }
    void Update()
    {
        
    }
    public void toggleStart(){
        SceneManager.LoadScene("JARDIN");
    }
     public void toggleQuit(){
        Application.Quit();
    }
}
