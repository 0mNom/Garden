using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpAds : MonoBehaviour
{
    public GameObject ad1;
    public bool adOn = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!adOn) StartCoroutine("PopUp");


    }

    IEnumerator PopUp()
    {
        adOn = true;
        yield return new WaitForSeconds(300);
        ad1.SetActive(true);
    }



}
