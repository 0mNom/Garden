using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    public BagScript bag;
    public Inventory invent;
    public PotPlaces places;

    public bool auto = false;

    public void Start()
    {
       // auto = true; 
    }

    public void Update()
    {

        //StartCoroutine("Start");
       // if (!auto) StartCoroutine("AutoSave");

    }




    public void LoadGame()
    {
        SaveData data = SaveManager.LoadGame();
        SaveDataPots dataP = SaveManager.LoadGameP();


        //Bag,money and Seeds
        bag.Monay = data.s_Money;
        bag.Gems = data.s_Gems;

        bag.wheatseed = data.s_wheat;
        bag.appleseed = data.s_apple;
        bag.tomatoseed = data.s_tomato;
        bag.eggplantseed = data.s_eggplant;
        bag.pearseed = data.s_pear;
        bag.sunflowerseed = data.s_sunflower;
        bag.cherryseed = data.s_cherry;
        bag.avoseed = data.s_avo;
        bag.kiwiseed = data.s_kiwi;

        //Pot places 

        //active pots? collectioin load

        places.p1 = dataP.s_p1;
        places.p2 = dataP.s_p2;
        places.p3 = dataP.s_p3;
        places.p4 = dataP.s_p4;
        places.p5 = dataP.s_p5;
        places.p6 = dataP.s_p6;
        places.p7 = dataP.s_p7;
        places.p8 = dataP.s_p8;
        places.p9 = dataP.s_p9;
        places.p10 = dataP.s_p10;

        //if the pot has been activated, what pot skin and which plant load
        if (dataP.s_p1)
        {
            places.sp1 = dataP.s_sp1;
            places.pp1 = dataP.s_pp1;
        }
        if (dataP.s_p2)
        {
            places.sp2 = dataP.s_sp2;
            places.pp2 = dataP.s_pp2;
        }
        if (dataP.s_p3)
        {
            places.sp3 = dataP.s_sp3;
            places.pp3 = dataP.s_pp3;
        }
        if (dataP.s_p4)
        {
            places.sp4 = dataP.s_sp4;
            places.pp4 = dataP.s_pp4;
        }
        if (dataP.s_p5)
        {
            places.sp5 = dataP.s_sp5;
            places.pp5 = dataP.s_pp5;
        }
        if (dataP.s_p6)
        {
            places.sp6 = dataP.s_sp6;
            places.pp6 = dataP.s_pp6;
        }
        if (dataP.s_p7)
        {
            places.sp7 = dataP.s_sp7;
            places.pp7 = dataP.s_pp7;
        }
        if (dataP.s_p8)
        {
            places.sp8 = dataP.s_sp8;
            places.pp8 = dataP.s_pp8;
        }
        if (dataP.s_p9)
        {
            places.sp9 = dataP.s_sp9;
            places.pp9 = dataP.s_pp9;
        }
        if (dataP.s_p10)
        {
            places.sp10 = dataP.s_sp10;
            places.pp10 = dataP.s_pp10;
        }
        places.loadplants();
        Debug.Log("Pots loaded");
    }

    public void SaveGame()
    {
        SaveManager.SaveGame(bag);
        SaveManager.SaveGameP(places);
        SaveManager.SaveGameI(invent);

    }

    IEnumerator start()
    {
        yield return new WaitForSeconds(30f);
    }

    IEnumerator AutoSave()
    {
        auto = true;
        SaveGame();
        Debug.Log("Saved");
        yield return new WaitForSeconds(30f);
        auto = false;
    }
}
