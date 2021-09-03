using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tankmovement : MonoBehaviour
{
    public float speed = 0.5f;

    public float rotationspeed = 10f;
    private void Start()
    {
       
    }
    
      
        void Update ()
        {
            float vertical = Input.GetAxis("Vertical");
            transform.Translate(0, 0, vertical * speed * Time.deltaTime);
        float Horizontal = Input.GetAxis("Horizontal");
        transform.Rotate( 0,Horizontal * rotationspeed * Time.deltaTime,0);
    }
    


}
