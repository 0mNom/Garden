using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DedLeaves : MonoBehaviour
{
    public Watering water;


    void Start()
    {
        water.deadleaves = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!water.deadleaves) Destroy(this);
    }
}
