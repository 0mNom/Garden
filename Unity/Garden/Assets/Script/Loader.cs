using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    public BagScript bag;
    public Inventory invent;
    public PotPlaces places;


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
    }

    public void SaveGame()
    {
        SaveManager.SaveGame();
    }
}
