using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMERA : MonoBehaviour
{
   public Camera cam;

    public float sensibilityX = 1;
    public float sensibilityY = 0.5f;
    public bool invertXAxis;
    public bool invertYAxis; 
    public Transform lookAt;
   
    private void FixedUpdate() {
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");

        v = (invertYAxis) ? (-v) : v ;

       if (h != 0){
           transform.Rotate(Vector3.up, h* 90 * sensibilityX * Time.deltaTime);
       } 
       if (v != 0){
           cam.transform.RotateAround(transform.position, transform.right, v * 90 * sensibilityY * Time.deltaTime);
       }

       cam.transform.LookAt(lookAt);
       Vector3 ea = cam.transform.rotation.eulerAngles;
       cam.transform.rotation = Quaternion.Euler(new Vector3(ea.x, ea.y, 0));
    }

}