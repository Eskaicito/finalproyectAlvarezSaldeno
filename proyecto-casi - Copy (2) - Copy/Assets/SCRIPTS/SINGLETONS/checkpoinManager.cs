using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class checkpoinManager : MonoBehaviour
{
    private Scene escenaActiva;
    private Scene jardinScene;
    private Scene alcantarillaScene;
    public Vector3 actualCP = Vector3.zero;
    private void Awake()
    {
        escenaActiva = (SceneManager.GetActiveScene());
        int countCM = FindObjectsOfType<checkpoinManager>().Length;
        if (actualCP == Vector3.zero)
        {
            actualCP = new Vector3(-183, 234, 254);
        }
        if (countCM > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Start()
    {
        Debug.Log("NASHEeeeeeeeEESAAA");
    }
}
