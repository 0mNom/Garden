using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutoSound : MonoBehaviour
{
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tutPause()
    {
        source.Pause();
    }
    public void tutPlay()
    {
        source.Play();
    }
}
