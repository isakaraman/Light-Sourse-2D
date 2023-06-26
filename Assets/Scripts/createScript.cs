using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createScript : MonoBehaviour
{
    public GameObject[] obj;
    float timer = 0;
    bool gamebool = true;

    GameObject obj1;
    void Update()
    {
        
         instantiate();
        if (!gamebool)
        {
            obj1.transform.Translate(new Vector3(0f, -2f * Time.deltaTime));
        }
           
    }
    void instantiate()
    {

        timer += Time.deltaTime;

        if (timer>=3)
        {
            obj1 = Instantiate(obj[0], new Vector3(0f, 6), Quaternion.identity);

            gamebool = false;
            timer = 0;
        }

    }
}
