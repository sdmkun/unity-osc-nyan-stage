using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Camera m_camera;

    [SerializeField]
    private float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        m_camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        m_camera.transform.position = (Vector3.forward * Mathf.Sin(Time.time * speed) + Vector3.left * Mathf.Cos(Time.time * speed)) * 10f + Vector3.up * 3f;
        m_camera.transform.LookAt(Vector3.zero);
    }
}
