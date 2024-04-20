using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatToScale : SynthControl
{
    [SerializeField]
    private float scale = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale = Vector3.one * this.fValue * scale;
    }
}
