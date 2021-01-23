using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotSkins : MonoBehaviour
{
   // public string tag;
    public PotPlaces places;
    public ButtonPopUp popUp;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void skin1()
    {
        if (popUp.Tag == "1") places.sp1 = 1;
        if (popUp.Tag == "2") places.sp2 = 1;
        if (popUp.Tag == "3") places.sp3 = 1;
        places.loadpots();

    }
    public void skin2()
    {
        if (popUp.Tag == "1") places.sp1 = 2;
        if (popUp.Tag == "2") places.sp2 = 2;
        if (popUp.Tag == "3") places.sp3 = 2;
        places.loadpots();

    }
    public void skin3()
    {
        if (popUp.Tag == "1") places.sp1 = 3;
        if (popUp.Tag == "2") places.sp2 = 3;
        if (popUp.Tag == "3") places.sp3 = 3;
        places.loadpots();

    }

}
