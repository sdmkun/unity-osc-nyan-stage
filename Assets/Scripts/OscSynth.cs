using OscJack;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class OscSynth : MonoBehaviour
{
    void Start()
    {
        var controls = this.GetComponentsInChildren<SynthControl>();

        foreach (var control in controls)
        {
            OSCManager.server.MessageDispatcher.AddCallback(
                string.Format("/{0}/{1}", this.name, control.transform.name),
                (string address, OscDataHandle data) =>
                {
                    control.SetFloat(data.GetElementAsFloat(0));
                }
            );
        }
    }

    void Update()
    {
        
    }
}
