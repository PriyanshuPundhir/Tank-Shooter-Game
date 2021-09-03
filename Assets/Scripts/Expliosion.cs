using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expliosion : MonoBehaviour
{
    public GameObject m_ExplosionParticles;
    
    

    // Start is called before the first frame update
    void Start()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        m_ExplosionParticles.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
