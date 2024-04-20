using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProceduralToolkit;

public class GeometryEmitter : MonoBehaviour
{
    [SerializeField]
    private GameObject m_obj;



    // Start is called before the first frame update
    void Start()
    {
        float radius = 2f;
        int hSegment = 4;
        int vSegment = 4;
        var draft = MeshDraft.Sphere(radius, hSegment, vSegment);
        var mesh = draft.ToMesh();
        m_obj = new GameObject("sphere");
        m_obj.AddComponent<MeshRenderer>();
        var mf = m_obj.AddComponent<MeshFilter>();
        mf.sharedMesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
