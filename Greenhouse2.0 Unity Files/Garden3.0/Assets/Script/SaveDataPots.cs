using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveDataPots
{
    public bool s_p1, s_p2, s_p3, s_p4, s_p5, s_p6, s_p7, s_p8, s_p9, s_p10; //pot places activated
    public int s_sp1, s_sp2, s_sp3, s_sp4, s_sp5, s_sp6, s_sp7, s_sp8, s_sp9, s_sp10; //skins on the active pots 
    public float s_pp1, s_pp2, s_pp3, s_pp4, s_pp5, s_pp6, s_pp7, s_pp8, s_pp9, s_pp10; //Plant in active pot
    public string s_TT1P1, s_TT2P1, s_TT3P1;
    public string s_TT1P2, s_TT2P2, s_TT3P2;
    public string s_TT1P3, s_TT2P3, s_TT3P3;
    public bool s_ble1,s_apple1, s_tomato1, s_eggplant1, s_pear1, s_sunflower1, s_cherry1, s_avocado1, s_kiwi1;
    public bool s_ble2,s_apple2, s_tomato2, s_eggplant2, s_pear2, s_sunflower2, s_cherry2, s_avocado2, s_kiwi2;
    public bool s_ble3,s_apple3, s_tomato3, s_eggplant3, s_pear3, s_sunflower3, s_cherry3, s_avocado3, s_kiwi3;

    public int s_sell1, s_sell2, s_sell3;
    public int s_lvl;

    public SaveDataPots(PotPlaces places)
    {

        //active pots? collectioin
        s_p1 = places.p1;
        s_p2 = places.p2;
        s_p3 = places.p3;
        s_p4 = places.p4;
        s_p5 = places.p5;
        s_p6 = places.p6;
        s_p7 = places.p7;
        s_p8 = places.p8;
        s_p9 = places.p9;
        s_p10 = places.p10;

        //target times
        s_TT1P1 = places.TT1P1;
        s_TT2P1 = places.TT2P1;
        s_TT3P1 = places.TT3P1;

        s_TT1P2 = places.TT1P2;
        s_TT2P2 = places.TT2P2;
        s_TT3P2 = places.TT3P2;

        s_TT1P3 = places.TT1P3;
        s_TT2P3 = places.TT2P3;
        s_TT3P3 = places.TT3P3;

        //fruit planted
        s_ble1 = places.ble1;
        s_apple1 = places.apple1;
        s_tomato1 = places.tomato1;
        s_eggplant1 = places.eggplant1;
        s_pear1 = places.pear1;
        s_sunflower1 = places.sunflower1;
        s_cherry1 = places.cherry1;
        s_avocado1 = places.avocado1;
        s_kiwi1 = places.kiwi1;


        s_ble2 = places.ble2;
        s_apple2 = places.apple2;
        s_tomato2 = places.tomato2;
        s_eggplant2 = places.eggplant2;
        s_pear2 = places.pear2;
        s_sunflower2 = places.sunflower2;
        s_cherry2 = places.cherry2;
        s_avocado2 = places.avocado2;
        s_kiwi2 = places.kiwi2;



        s_ble3 = places.ble3;
        s_apple3 = places.apple3;
        s_tomato3 = places.tomato3;
        s_eggplant3 = places.eggplant3;
        s_pear3 = places.pear3;
        s_sunflower3 = places.sunflower3;
        s_cherry3 = places.cherry3;
        s_avocado3 = places.avocado3;
        s_kiwi3 = places.kiwi3;

        //selling price

        s_sell1 = places.sell1;
        s_sell2 = places.sell2;
        s_sell3 = places.sell3;


        s_lvl = places.lvl;


        //if the pot has been activated, what pot skin and which plant
        if (s_p1)
        {
            s_sp1 = places.sp1;
            s_pp1 = places.pp1;
        }
        if (s_p2)
        {
            s_sp2 = places.sp2;
            s_pp2 = places.pp2;
        }
        if (s_p3)
        {
            s_sp3 = places.sp3;
            s_pp3 = places.pp3;
        }
        if (s_p4)
        {
            s_sp4 = places.sp4;
            s_pp4 = places.pp4;
        }
        if (s_p5)
        {
            s_sp5 = places.sp5;
            s_pp5 = places.pp5;
        }
        if (s_p6)
        {
            s_sp6 = places.sp6;
            s_pp6 = places.pp6;
        }
        if (s_p7)
        {
            s_sp7 = places.sp7;
            s_pp7 = places.pp7;
        }
        if (s_p8)
        {
            s_sp8 = places.sp8;
            s_pp8 = places.pp8;
        }
        if (s_p9)
        {
            s_sp9 = places.sp9;
            s_pp9 = places.pp9;
        }
        if (s_p10)
        {
            s_sp10 = places.sp10;
            s_pp10 = places.pp10;
        }
    }
}
