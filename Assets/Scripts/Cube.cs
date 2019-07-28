using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : MonoBehaviour
{
    public float m_Life = 0;
    public Text m_LifeDisplay = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(float damage)
    {
        m_Life -= damage;
        m_LifeDisplay.text = Mathf.Max(0, m_Life).ToString();
        Debug.Log(gameObject.name + ":" + m_Life);
        if (m_Life <= 0)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
