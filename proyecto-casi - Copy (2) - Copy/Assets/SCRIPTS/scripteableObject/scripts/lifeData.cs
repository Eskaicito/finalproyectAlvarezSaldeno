using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New life enemy data", menuName ="lifeData")]
public class lifeData : ScriptableObject
{
[SerializeField] public float enemyLife = 300f;
[SerializeField] public float maxEnemyLife;
[SerializeField] public float actualEnemyLife;
 [SerializeField] public bool persecucion;
 [SerializeField] public bool playerDetectado;
 [SerializeField] public bool timerOnOff;
}
