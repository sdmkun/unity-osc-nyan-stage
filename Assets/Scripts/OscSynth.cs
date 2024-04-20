using OscJack;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class OscSynth : MonoBehaviour
{
    public string ipAddress = "127.0.0.1";
    public int portNumber = 12345;

    public OscClient Client
    {
        get; private set;
    }

    public OscServer Server
    {
        get; private set;
    }


    void Start()
    {
        Client = new OscClient(ipAddress, portNumber);
        Server = new OscServer(portNumber);

        var controls = this.GetComponentsInChildren<SynthControl>();

        foreach (var control in controls)
        {
            Server.MessageDispatcher.AddCallback(
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


    private void OnDestroy()
    {
        Client.Dispose();
        Server.Dispose();
    }
}
