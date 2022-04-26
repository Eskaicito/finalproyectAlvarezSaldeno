using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterIra : MonoBehaviour
{
   [SerializeField] lifeData lifeData;

   private void Update() {
       if (lifeData.enemyLife < 1){
           GameManager.instance.IRADEATH ++;
       }
   }
}
