using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New enemy data", menuName = "enemyData")]
public class enemyData : ScriptableObject
{

    [SerializeField] public float timer;
    [SerializeField] public int monedasDrop;
    [SerializeField] private float distanciaAtaqueEnemy;
    [SerializeField] private int enemyDamage;
    
    
   
    [SerializeField] public float distanciaPlayer;
    [SerializeField] public GameObject player;
    [SerializeField] public float speed;
    [SerializeField] public static Animator Animator;

    public int EnemyDamage { get { return enemyDamage; } }

    public float Speed { get { return speed; } }
    public float DistanciaAtaqueEnemy { get { return distanciaAtaqueEnemy; } }
}
