using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    public BagScript bag;
   // public Inventory invent;
    //public PotPlaces places;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGame()
    {
        SaveData data = SaveManager.LoadGame();

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
    }

    public void SaveGame()
    {
        SaveManager.SaveGame(bag);
    }
}
