using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform m_Target = null;
    public Vector3 m_FollowPosition = Vector3.zero;
    public Vector3 m_FollowRotation = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Target != null)
        {
            transform.position = m_Target.position + m_FollowPosition;
            transform.eulerAngles = m_FollowRotation;
        }
    }
}
