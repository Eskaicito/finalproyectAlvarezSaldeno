using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luciferTorreta : MonoBehaviour
{
    [SerializeField] luciferData luciferData;
    void Update()
    {
        Vector3 targetOrientation = luciferData.player.transform.position - transform.position;
        Debug.DrawRay (transform.position, targetOrientation, Color.red);

        //Orientar instantaneo
        //transform.rotation = Quaternion.LookRotation(targetOrientation);

        //Slerp
        Quaternion targetOrientationQuaternion = Quaternion.LookRotation(targetOrientation);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetOrientationQuaternion, Time.deltaTime);
    }
}
