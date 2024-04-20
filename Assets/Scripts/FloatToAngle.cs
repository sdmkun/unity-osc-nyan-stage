using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatToAngle : SynthControl
{
    [SerializeField]
    private float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(this.fValue * speed, 0, 0));
        this.fValue = 0;
    }
}
