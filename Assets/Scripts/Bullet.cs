using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float m_Countdown = 10f;

    // Start is called before the first frame update
    void Start()
    {
        m_Countdown -= Time.deltaTime;
        if (m_Countdown <= 0)
        {
            GameObject.Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag.Equals("Target"))
        {
            Cube cube = collision.collider.gameObject.GetComponent<Cube>();
            cube.Damage(15);
            GameObject.Destroy(gameObject);
        }
    }

}
