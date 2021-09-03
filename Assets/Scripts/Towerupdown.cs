using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towerupdown : MonoBehaviour
{
    public float speed = 0.5f;

    public float rotationspeed = 10f;
    private void Start()
    {

    }


    void Update()
    {
        float Horizontal = Input.GetAxis("Mouse Y") * rotationspeed * Time.deltaTime;

    }



}
