using OscJack;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OSCManager : MonoBehaviour
{
    public static string ipAddress = "127.0.0.1";
    public static int portNumber = 12345;

    public static OscClient client = new OscClient(ipAddress, portNumber);
    public static OscServer server = new OscServer(portNumber);


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
