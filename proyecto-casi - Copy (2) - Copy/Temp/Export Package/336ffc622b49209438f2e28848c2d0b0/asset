using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	[SerializeField] AudioClip[] audios;
	public AudioManager instance;
	private AudioSource controlAudio;
	
	private void Awake()
	{
		if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
		}
		else
        {
            Destroy(gameObject);
        }
		controlAudio=GetComponent<AudioSource>();
	}
	public void seleccionAudio(int indice, float volumen){
		controlAudio.PlayOneShot(audios [indice], volumen);
	}
	/*public void combate(){
		for (int i = 0; i < audios.Length; i++){
			controlAudio.Play(15);
		}
	}*/
    
}
