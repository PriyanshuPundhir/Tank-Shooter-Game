using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missilemovement : MonoBehaviour
{
    public Transform Tower;
   
    public float towerspeed;
    
    float towerangle;
    


    // Update is called once per frame
    void Update()
    {
        rotatetower();
        

    }
    void rotatetower()
    {
        towerangle += Input.GetAxis("Mouse X") * towerspeed * -Time.deltaTime;
        towerangle = Mathf.Clamp(towerangle, 0, 1800);
        Tower.localRotation = Quaternion.AngleAxis(towerangle, Vector3.up);
        
    }
    
}
