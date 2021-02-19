using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioClip s_PotPlaced, s_buy, s_buyMoney, s_buySeeds, s_ScreenSwosh, BG_music, s_pop, s_openBag, s_water;

    private AudioSource source { get { return GetComponent<AudioSource>(); } }


    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = BG_music;
        source.playOnAwake = false;

        source.volume = 0.5f;

        source.clip = BG_music;
        source.PlayOneShot(BG_music);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void potPlaced()
    {
        source.clip = s_PotPlaced;
        source.PlayOneShot(s_PotPlaced);
    }

    public void buy()
    {
        source.clip = s_buy;
        source.PlayOneShot(s_buy);
    }

    public void BuyMoney()
    {
        source.clip = s_buyMoney;
        source.PlayOneShot(s_buyMoney);
    }

    public void BuySeeds()
    {
        source.clip = s_buySeeds;
        source.PlayOneShot(s_buySeeds);
    }

    public void Swoosh()
    {
        source.clip = s_ScreenSwosh;
        source.PlayOneShot(s_ScreenSwosh);
    }

     public void pop()
    {
        source.clip = s_pop;
        source.PlayOneShot(s_pop);
    }


     public void openBag()
    {
        source.clip = s_pop;
        source.PlayOneShot(s_pop);
    }

       public void water()
    {
        source.clip = s_water;
        source.PlayOneShot(s_water);
    }



}
