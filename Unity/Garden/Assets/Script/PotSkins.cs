using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotSkins : MonoBehaviour
{
   // public string tag;
    public PotPlaces places;
    public ButtonPopUp popUp;
    public Inventory inv;


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
        if (popUp.Tag == "4") places.sp4 = 1;
        if (popUp.Tag == "5") places.sp5 = 1;
        if (popUp.Tag == "6") places.sp6 = 1;
        if (popUp.Tag == "7") places.sp7 = 1;
        if (popUp.Tag == "8") places.sp8 = 1;
        if (popUp.Tag == "9") places.sp9 = 1;
        if (popUp.Tag == "10") places.sp10 = 1;
        places.loadpots();

    }
    public void skin2()
    {
        if (popUp.Tag == "1") places.sp1 = 2;
        if (popUp.Tag == "2") places.sp2 = 2;
        if (popUp.Tag == "3") places.sp3 = 2;
        if (popUp.Tag == "4") places.sp4 = 2;
        if (popUp.Tag == "5") places.sp5 = 2;
        if (popUp.Tag == "6") places.sp6 = 2;
        if (popUp.Tag == "7") places.sp7 = 2;
        if (popUp.Tag == "8") places.sp8 = 2;
        if (popUp.Tag == "9") places.sp9 = 2;
        if (popUp.Tag == "10") places.sp10 = 2;
        places.loadpots();

    }
    public void skin3()
    {
        if (popUp.Tag == "1") places.sp1 = 3;
        if (popUp.Tag == "2") places.sp2 = 3;
        if (popUp.Tag == "3") places.sp3 = 3;
        if (popUp.Tag == "4") places.sp4 = 3;
        if (popUp.Tag == "5") places.sp5 = 3;
        if (popUp.Tag == "6") places.sp6 = 3;
        if (popUp.Tag == "7") places.sp7 = 3;
        if (popUp.Tag == "8") places.sp8 = 3;
        if (popUp.Tag == "9") places.sp9 = 3;
        if (popUp.Tag == "10") places.sp10 = 3;
        places.loadpots();

    }
     public void skin4()
    {
        if (popUp.Tag == "1") places.sp1 = 4;
        if (popUp.Tag == "2") places.sp2 = 4;
        if (popUp.Tag == "3") places.sp3 = 4;
        if (popUp.Tag == "4") places.sp4 = 4;
        if (popUp.Tag == "5") places.sp5 = 4;
        if (popUp.Tag == "6") places.sp6 = 4;
        if (popUp.Tag == "7") places.sp7 = 4;
        if (popUp.Tag == "8") places.sp8 = 4;
        if (popUp.Tag == "9") places.sp9 = 4;
        if (popUp.Tag == "10") places.sp10 = 4;
        places.loadpots();

    }

}
