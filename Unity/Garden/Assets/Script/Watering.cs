using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watering : MonoBehaviour
{
    public GameObject particle;
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
        if (deadleaves) deadleaves = !deadleaves;
    }
}
