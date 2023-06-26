using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movescript : MonoBehaviour
{
    public float xMove, yMove;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-xMove*Time.deltaTime, 0f));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(xMove * Time.deltaTime, 0f));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0f, yMove * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0f, -yMove * Time.deltaTime));
        }
    }

}
