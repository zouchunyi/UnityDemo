using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Lerp(Quaternion.Euler(new Vector3(0, 45, 0)), Quaternion.Euler(new Vector3(0, -45, 0)), Mathf.Sin(Mathf.Deg2Rad * (Time.frameCount % 180)));
    }
}
