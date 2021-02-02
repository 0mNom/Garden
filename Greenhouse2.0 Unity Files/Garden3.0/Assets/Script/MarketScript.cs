using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketScript : MonoBehaviour
{
    public GameObject MarketPannel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenMarket()
    {
        MarketPannel.SetActive(true);
    }
    public void CloseMarket()
    {
        MarketPannel.SetActive(false);
    }

}
