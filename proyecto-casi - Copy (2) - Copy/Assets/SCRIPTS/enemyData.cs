using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New enemy data", menuName ="enemyData")]
public class enemyData : ScriptableObject
{
    [SerializeField] public float enemyLife;
    [SerializeField] public float timer;
    [SerializeField] public float actualEnemyLife;
    [SerializeField] private float distanciaAtaqueEnemy;
    [SerializeField] private int enemyDamage;
    [SerializeField]public bool playerDetectado;
    [SerializeField]public bool timerOnOff;
    [SerializeField]public bool persecucion;
    [SerializeField]public float distanciaPlayer;
    [SerializeField] public GameObject player;
    [SerializeField] private float speed;
    [SerializeField] public static Animator Animator;

    public int EnemyDamage { get {return enemyDamage; } }
    
    public float Speed { get {return speed; } }
    public float DistanciaAtaqueEnemy { get {return distanciaAtaqueEnemy; } }
}
