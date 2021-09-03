
using UnityEngine;

public class Firescript : MonoBehaviour
{
    public float damage = 10f;
    public float range = 150f;
    public Camera fpscam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();

        }
    }
    void shoot ()
    {


    }
}
