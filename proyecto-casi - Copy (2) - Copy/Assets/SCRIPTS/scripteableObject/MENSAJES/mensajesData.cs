using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New text data", menuName = "MensajeData")]

public class mensajesData : ScriptableObject
{
   [SerializeField] private string blabla;
   [SerializeField] private float timeWaiting = 3f;
   [SerializeField] private bool vuelveAparecer = true;
   public bool textOn = false;

   public string Blabla { get { return blabla; } }
   public float TimeWaiting { get { return timeWaiting; } }
   public bool VuelveAparecer { get { return vuelveAparecer; } }
}
