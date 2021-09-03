using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraswitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("1key"))
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
        if (Input.GetButtonDown("2key"))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }
}
