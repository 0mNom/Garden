using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioClip s_PotPlaced, s_buy, s_start, s_upgrade, s_evolution, s_planted, s_inventO, s_inventC, s_market, s_tab, s_pop, s_closeSeedBag, s_water, s_close, s_sellPlant, s_error,  s_openSeedBag;
    

    private AudioSource source { get { return GetComponent<AudioSource>(); } }


    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        //source.clip = BG_music;
        source.playOnAwake = false;

        source.volume = 0.3f;

        //source.clip = BG_music;
        //source.PlayOneShot(BG_music);
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

  

     public void pop()
    {
        source.clip = s_pop;
        source.PlayOneShot(s_pop);
    }


     public void closeSeedBag()
    {
        source.clip = s_closeSeedBag;
        source.PlayOneShot(s_closeSeedBag);
    }

       public void water()
    {
        source.clip = s_water;
        source.PlayOneShot(s_water);
    }

       public void close()
    {
        source.clip = s_close;
        source.PlayOneShot(s_close);
    }


          public void sell()
    {
        source.clip = s_sellPlant;
        source.PlayOneShot(s_sellPlant);
    }

    public void openSeedBag()
    {
        source.clip = s_openSeedBag;
        source.PlayOneShot(s_openSeedBag);
    }

    public void startgame()
    {
        source.clip = s_start;
        source.PlayOneShot(s_start);
    }

    public void levelUp()
    {
        source.clip = s_upgrade;
        source.PlayOneShot(s_upgrade);
    }

    public void planting()
    {
        source.clip = s_planted;
        source.PlayOneShot(s_planted);
    }

    public void changeTab()
    {
        source.clip = s_tab;
        source.PlayOneShot(s_tab);
    }

    public void inventO()
    {
        source.clip = s_inventO;
        source.PlayOneShot(s_inventO);
    }

    public void inventC()
    {
        source.clip = s_inventC;
        source.PlayOneShot(s_inventC);
    }
    

    public void market()
    {
        source.clip = s_market;
        source.PlayOneShot(s_market);
    }

    public void error()
    {
        source.clip = s_error;
        source.PlayOneShot(s_error);
    }

    public void evol()
    {
        source.clip = s_evolution;
        source.PlayOneShot(s_evolution);
    }


}


