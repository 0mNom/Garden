using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowTrigger : MonoBehaviour
{

    public Dialogue dialogue;

    public void TriggerWindow ()
    {
        FindObjectOfType<WindowManager>().StartDialogue(dialogue);
    
    }
}
