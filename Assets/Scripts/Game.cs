using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject m_Bullet = null;
    public Transform m_Shooter = null;

    public GameObject[] m_Cubes = null;

    public RectTransform UIStart = null;
    public RectTransform UIAttack = null;
    public RectTransform UIWin = null;

    private enum GameState
    {
        Ready,
        Gaming,
        Win
    }

    private GameState m_GameState = GameState.Ready;

    // Start is called before the first frame update
    void Start()
    {
        ChangeState(GameState.Ready);
    }

    // Update is called once per frame
    void Update()
    {
        if (m_GameState == GameState.Gaming)
        {
            int i = 0;
            for (; i < m_Cubes.Length; ++i)
            {
                if (m_Cubes[i] != null)
                {
                    break;
                }
            }
            if (i == m_Cubes.Length)
            {
                ChangeState(GameState.Win);
            }
        }
    }

    void ChangeState(GameState newState)
    {
        UIStart.localScale = Vector3.zero;
        UIAttack.localScale = Vector3.zero;
        UIWin.localScale = Vector3.zero;
        switch (newState)
        {
            case GameState.Ready:
                UIStart.localScale = Vector3.one;;
                break;
            case GameState.Gaming:
                UIAttack.localScale = Vector3.one; ;
                break;
            case GameState.Win:
                UIWin.localScale = Vector3.one; ;
                break;
        }

        m_GameState = newState;
    }

    //void OnGUI()
    //{
    //    if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height - 50, 100, 50), "Shoot"))
    //    {

    //    }
    //}

    public void GameStart()
    {
        ChangeState(GameState.Gaming);
    }

    public void Attack()
    {
        GameObject newBullet = GameObject.Instantiate(m_Bullet);
        newBullet.transform.position = m_Shooter.transform.localToWorldMatrix.MultiplyPoint3x4(new Vector3(0, 0, 0.5f));// m_Shooter.position;
        //newBullet.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 50));
        newBullet.transform.rotation = m_Shooter.rotation;
        newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * 50);
    }
}
