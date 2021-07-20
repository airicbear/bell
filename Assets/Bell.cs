using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bell : MonoBehaviour
{
    public float force = 1000f;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
                GetComponent<AudioSource>().Play(0);
            }
        }
    }
}
