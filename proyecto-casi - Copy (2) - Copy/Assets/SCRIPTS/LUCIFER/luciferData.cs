using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "luciferData")]
public class luciferData : ScriptableObject {
    [SerializeField] public float luciferLife;
    [SerializeField] public float luciferMaxLife;
    [SerializeField] public float distanciaPlayer;
    [SerializeField] public GameObject bolaFuego1;
    [SerializeField] public GameObject bolaFuego2;
    
    [SerializeField] public GameObject player;
    [SerializeField] static public GameObject luciferBullet;
    
    [SerializeField] public float timerBalas;
    [SerializeField] static public float lifebullet = 5;
    [SerializeField] static public float bulletSpeed = 70;
}