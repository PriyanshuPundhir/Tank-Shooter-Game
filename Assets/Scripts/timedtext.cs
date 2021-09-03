using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timedtext : MonoBehaviour
{
    public GameObject thesub;
   // public AudioSource audiosub;
    IEnumerator Subtivoice()
    {
        yield return new WaitForSeconds(2f);
        //audiosub.Play();
        thesub.GetComponent<Text>().text = "Take Down all the enemies!!";
        yield return new WaitForSeconds(5f);
        thesub.GetComponent<Text>().text = "";
    }
    private void Start()
    {
        StartCoroutine(Subtivoice());
    }
}