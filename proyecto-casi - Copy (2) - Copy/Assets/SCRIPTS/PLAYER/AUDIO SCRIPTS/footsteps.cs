using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{

    private AudioSource audioSource;
    // Start is called before the first frame update
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    private void Update()
    {

    }
    private void footstepsSound()
    {
        audioSource.Play();
    }

}
