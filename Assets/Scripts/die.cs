using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{
    // Start is called before the first frame update
    public Enemycount obj1;
    void OnTriggerEnter()
    {
        
        
        // Remove the current object
        Destroy(gameObject);
        obj1.countenm -= 1;
    }
}
