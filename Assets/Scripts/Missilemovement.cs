using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missilemovement1 : MonoBehaviour
{
   
    public Transform cannon;
  
    public float cannonspeed;
    
    float cannonanlge;
    

    // Update is called once per frame
    void Update()
    {
       
        rotatecannon();

    }
    
    void rotatecannon()
    {
        cannonanlge += Input.GetAxis("Mouse Y") * cannonspeed * -Time.deltaTime;
        cannonanlge = Mathf.Clamp(cannonanlge, -10, 10);
        cannon.localRotation = Quaternion.AngleAxis(cannonanlge, Vector3.right);

    }
}
