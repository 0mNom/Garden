using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watering : MonoBehaviour
{
    public GameObject particle, particle1;
    public bool deadleaves;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void water()
    {
        Instantiate(particle);
        Instantiate(particle1);
        //if (deadleaves) deadleaves = !deadleaves;
    }
}
