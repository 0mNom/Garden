using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveDataInv
{
    public int s_pot1, s_pot2, s_pot3, s_pot4, s_pot5, s_pot6, s_pot7; //number of each kind of pot


    public SaveDataInv(Inventory invent)
    {
        //object inventory colleection
        s_pot1 = invent.pot1;
        s_pot2 = invent.pot2;
        s_pot3 = invent.pot3;
        s_pot4 = invent.pot4;
        s_pot5 = invent.pot5;
        s_pot6 = invent.pot6;
        s_pot7 = invent.pot7;

    }
}
