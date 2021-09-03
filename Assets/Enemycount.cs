using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemycount : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject enemc;
    public int countenm=10;

    // Update is called once per frame
    void Update()
    {
        enemc.GetComponent<Text>().text = "Enemy Left - "+countenm;
        if(countenm==0)
        {
            //Winning condition or screen;
        }
    }
}
