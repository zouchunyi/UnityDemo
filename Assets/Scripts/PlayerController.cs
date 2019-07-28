using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController m_CharacterController = null;
    public Animator m_Animator = null;
    public float m_Speed = 0;

    private Vector3 m_CurSpeedDir = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            m_CurSpeedDir = transform.forward;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            m_CurSpeedDir = -transform.forward;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            m_CurSpeedDir = -transform.right;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            m_CurSpeedDir = transform.right;
        }
        else if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            m_CurSpeedDir = Vector3.zero;
        }

        CharacterMove(m_CurSpeedDir * m_Speed);
    }

    private void CharacterMove(Vector3 speed)
    {
        m_CharacterController.SimpleMove(speed);

        if (m_CurSpeedDir.Equals(Vector3.zero))
        {
            m_Animator.SetFloat("speed", 0);
        }
        else
        {
            m_Animator.SetFloat("speed", 1);
            transform.LookAt(transform.position + m_CurSpeedDir);
        }

        //Vector3.Angle(transform.eulerAngles, m_CurSpeedDir);
        //Quaternion.Slerp(transform.rotation,)
    }
}
