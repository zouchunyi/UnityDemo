using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody m_Rigidbody = null;

    public float m_OffsetY = 0;

    // Start is called before the first frame update
    void Start()
    {
        //m_Rigidbody = this.GetComponent<Rigidbody>();
        m_Rigidbody.useGravity = false;
        transform.position += new Vector3(0, m_OffsetY, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 100, 50), "Start"))
        {
            m_Rigidbody.useGravity = true;
        }
    }
}
