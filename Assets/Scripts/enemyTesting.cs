using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class enemyTesting : MonoBehaviour
{
    float vecX = 0, vecY = 0, vecX2 = 0, vecY2 = 0, timer1, timer2;
    int a, b, c;
    bool directionBool = true,lightsourceBool=true;

    public float moveTime;
    public Light2D mainLight;
    public Light2D enemyLight;

    public Rigidbody2D rigid;
    void Start()
    {
        a = 3;
        b = 4;
    }

    private void Update()
    {
        if (directionBool)
        {
            goingTheLight();
            transform.Translate(new Vector3(vecX * Time.deltaTime, vecY * Time.deltaTime));
        }
        else
        {
            goingTheBase();
            transform.Translate(new Vector3(vecX2 * Time.deltaTime, vecY2 * Time.deltaTime));
        }
    }

    void goingTheLight()
    {

        Debug.DrawRay(new Vector2(transform.position.x + 0.3f, transform.position.y), transform.TransformDirection(new Vector3(1f, 0, 0)), Color.red);
        Debug.DrawRay(new Vector2(transform.position.x + 0.2f, transform.position.y + 0.2f), transform.TransformDirection(new Vector3(1f, 0.4f, 0)), Color.blue);
        Debug.DrawRay(new Vector2(transform.position.x + 0.2f, transform.position.y + -0.2f), transform.TransformDirection(new Vector3(0.8f, -0.8f, 0)), Color.black);
        Debug.DrawRay(new Vector2(transform.position.x, transform.position.y - 0.3f), transform.TransformDirection(new Vector3(0, -1f, 0)), Color.grey);
        Debug.DrawRay(new Vector2(transform.position.x + -0.2f, transform.position.y + -0.2f), transform.TransformDirection(new Vector3(-0.4f, -1f, 0)), Color.white);
        Debug.DrawRay(new Vector2(transform.position.x + -0.2f, transform.position.y + 0.2f), transform.TransformDirection(new Vector3(-0.8f, 0.8f, 0)), Color.green);
        Debug.DrawRay(new Vector2(transform.position.x, transform.position.y + 0.3f), transform.TransformDirection(new Vector3(0.4f, 1f, 0)), Color.cyan);

        RaycastHit2D hit1 = Physics2D.Raycast(new Vector2(transform.position.x + 0.3f, transform.position.y), transform.TransformDirection(new Vector3(1f, 0, 0)), 1f);
        RaycastHit2D hit2 = Physics2D.Raycast(new Vector2(transform.position.x + 0.2f, transform.position.y + 0.2f), transform.TransformDirection(new Vector3(1f, 0.4f, 0)), 1.1f);
        RaycastHit2D hit6 = Physics2D.Raycast(new Vector2(transform.position.x + 0.2f, transform.position.y + -0.2f), transform.TransformDirection(new Vector3(0.8f, -0.8f, 0)), 1.15f);
        RaycastHit2D hit7 = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y - 0.3f), transform.TransformDirection(new Vector3(0, -1f, 0)), 1f);
        RaycastHit2D hit8 = Physics2D.Raycast(new Vector2(transform.position.x + -0.2f, transform.position.y + -0.2f), transform.TransformDirection(new Vector3(-0.4f, -1f, 0)), 1.1f);
        RaycastHit2D hit4 = Physics2D.Raycast(new Vector2(transform.position.x + -0.2f, transform.position.y + 0.2f), transform.TransformDirection(new Vector3(-0.8f, 0.8f, 0)), 1.15f);
        RaycastHit2D hit9 = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y + 0.3f), transform.TransformDirection(new Vector3(0.4f, 1f, 0)), 1.1f);



        if (hit1.collider != null)
        {
            if (hit1.collider.tag == "wall")
            {
                if (a == 1)
                {
                    a = Random.Range(2, 8);
                }
            }
            if (hit1.collider.tag != "wall" && a == 1)
            {
                vecX = 1f;
                vecY = 0;
                timer1 += Time.deltaTime;
                if (timer1 >= moveTime)
                {
                    a = Random.Range(1, 8);
                    timer1 = 0f;

                }
            }
        }

        if (hit2.collider != null) 
        {
            if (hit2.collider.tag == "wall")
            {
                if (a == 2)
                {
                    a = Random.Range(3, 8);
                }

            }
            if (hit2.collider.tag != "wall" && a == 2)
            {
                vecX = 0.9f;
                vecY = 0.4f;
                timer1 += Time.deltaTime;
                if (timer1 >= moveTime)
                {
                    a = Random.Range(1, 8);
                    timer1 = 0f;

                }
            }
        }

        if (hit6.collider != null)
        {
            if (hit6.collider.tag == "wall")
            {
                if (a == 3)
                {
                    a = Random.Range(4, 8);
                }
            }
            if (hit6.collider.tag != "wall" && a == 3)
            {
                vecX = 0.8f;
                vecY = -0.8f;
                timer1 += Time.deltaTime;
                if (timer1 >= moveTime)
                {
                    a = Random.Range(1, 8);
                    timer1 = 0f;

                }
            }
        }

        if (hit7.collider != null)
        {
            if (hit7.collider.tag == "wall")
            {
                if (a == 4)
                {
                    a = Random.Range(1, 4);
                }

            }
            if (hit7.collider.tag != "wall" && a == 4)
            {

                vecX = 0f;
                vecY = -1f;
                timer1 += Time.deltaTime;
                if (timer1 >= moveTime)
                {
                    a = Random.Range(1, 8);
                    timer1 = 0f;

                }
            }
        }

        if (hit8.collider != null)
        {
            if (hit8.collider.tag == "wall")
            {
                if (a == 5)
                {
                    a = Random.Range(1, 5);
                }

            }
            if (hit8.collider.tag != "wall" && a == 5)
            {

                vecX = -0.4f;
                vecY = -0.9f;
                timer1 += Time.deltaTime;
                if (timer1 >= moveTime)
                {
                    a = Random.Range(1, 8);
                    timer1 = 0f;

                }
            }
        }

        if (hit4.collider != null)
        {
            if (hit4.collider.tag == "wall")
            {
                if (a == 6)
                {
                    a = Random.Range(1, 6);
                }
            }
            if (hit4.collider.tag != "wall" && a == 6)
            {
                vecX = -0.8f;
                vecY = 0.8f;
                timer1 += Time.deltaTime;
                if (timer1 >= moveTime)
                {
                    a = Random.Range(1, 8);
                    timer1 = 0f;

                }
            }
        }

        if (hit9.collider != null)
        {
            if (hit9.collider.tag == "wall")
            {
                if (a == 7)
                {
                    a = Random.Range(1, 7);
                }

            }
            if (hit9.collider.tag != "wall" && a == 7)
            {
                vecX = 0.4f;
                vecY = 0.9f;
                timer1 += Time.deltaTime;
                if (timer1 >= moveTime)
                {
                    a = Random.Range(1, 8);
                    timer1 = 0f;

                }
            }
        }
    }

    void goingTheBase()
    {
        Debug.DrawRay(new Vector2(transform.position.x + 0.2f, transform.position.y + 0.2f), transform.TransformDirection(new Vector3(0.4f, 1f, 0)), Color.blue);
        Debug.DrawRay(new Vector2(transform.position.x, transform.position.y + 0.3f), transform.TransformDirection(new Vector3(0, 1f, 0)), Color.yellow);
        Debug.DrawRay(new Vector2(transform.position.x + -0.2f, transform.position.y + 0.2f), transform.TransformDirection(new Vector3(-0.8f, 0.8f, 0)), Color.green);
        Debug.DrawRay(new Vector2(transform.position.x + -0.3f, transform.position.y), transform.TransformDirection(new Vector3(-1f, 0, 0)), Color.magenta);
        Debug.DrawRay(new Vector2(transform.position.x + -0.2f, transform.position.y + -0.2f), transform.TransformDirection(new Vector3(-1f, -0.4f, 0)), Color.white);
        Debug.DrawRay(new Vector2(transform.position.x + 0.2f, transform.position.y + -0.2f), transform.TransformDirection(new Vector3(0.8f, -0.8f, 0)), Color.black);
        Debug.DrawRay(new Vector2(transform.position.x, transform.position.y + -0.3f), transform.TransformDirection(new Vector3(-0.4f, -1f, 0)), Color.cyan);

        RaycastHit2D hit2 = Physics2D.Raycast(new Vector2(transform.position.x + 0.2f, transform.position.y + 0.2f), transform.TransformDirection(new Vector3(0.4f, 0.9f, 0)), 1.1f);
        RaycastHit2D hit3 = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y + 0.3f), transform.TransformDirection(new Vector3(0, 1f, 0)), 1f);
        RaycastHit2D hit4 = Physics2D.Raycast(new Vector2(transform.position.x + -0.2f, transform.position.y + 0.2f), transform.TransformDirection(new Vector3(-0.8f, 0.8f, 0)), 1.15f);
        RaycastHit2D hit5 = Physics2D.Raycast(new Vector2(transform.position.x + -0.3f, transform.position.y), transform.TransformDirection(new Vector3(-1f, 0, 0)), 1f);
        RaycastHit2D hit8 = Physics2D.Raycast(new Vector2(transform.position.x + -0.2f, transform.position.y + -0.2f), transform.TransformDirection(new Vector3(-0.9f, -0.4f, 0)), 1.1f);
        RaycastHit2D hit6 = Physics2D.Raycast(new Vector2(transform.position.x + 0.2f, transform.position.y + -0.2f), transform.TransformDirection(new Vector3(0.8f, -0.8f, 0)), 1.15f);
        RaycastHit2D hit10 = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y + -0.3f), transform.TransformDirection(new Vector3(-0.4f, -0.9f, 0)), 1.1f);

        if (hit2.collider!=null)
        {
            if (hit2.collider.tag == "wall")
            {
                if (b == 1)
                {
                    b = Random.Range(2, 8);
                }

            }
            if (hit2.collider.tag != "wall" && b == 1)
            {
                vecX2 = 0.4f;
                vecY2 = 0.9f;
                timer2 += Time.deltaTime;
                if (timer2 >= 1f)
                {
                    b = Random.Range(1, 8);
                    timer2 = 0f;

                }
            }
        }

        if (hit3.collider!=null)
        {
            if (hit3.collider.tag == "wall")
            {

                if (b == 2)
                {
                    b = Random.Range(3, 8);
                }
            }
            if (hit3.collider.tag != "wall" && b == 2)
            {
                vecX2 = 0f;
                vecY2 = 1f;

                timer2 += Time.deltaTime;
                if (timer2 >= moveTime)
                {
                    b = Random.Range(1, 8);
                    timer2 = 0f;

                }

            }
        }

        if (hit4.collider!=null)
        {
            if (hit4.collider.tag == "wall")
            {
                if (b == 3)
                {
                    b = Random.Range(4, 8);
                }
            }
            if (hit4.collider.tag != "wall" && b == 3)
            {
                vecX2 = -0.8f;
                vecY2 = 0.8f;
                timer2 += Time.deltaTime;
                if (timer2 >= moveTime)
                {
                    b = Random.Range(1, 8);
                    timer2 = 0f;

                }
            }
        }

        if (hit5.collider!=null)
        {
            if (hit5.collider.tag == "wall")
            {
                if (b == 4)
                {
                    b = Random.Range(5, 8);
                }
            }
            if (hit5.collider.tag != "wall" && b == 4)
            {
                vecX2 = -1f;
                vecY2 = 0f;
                timer2 += Time.deltaTime;
                if (timer2 >= moveTime)
                {
                    b = Random.Range(1, 8);
                    timer2 = 0f;

                }
            }
        }

        if (hit8.collider != null)
        {
            if (hit8.collider.tag == "wall")
            {
                if (b == 5)
                {
                    b = Random.Range(1, 5);
                }
            }
            if (hit8.collider.tag != "wall" && b == 5)
            {

                vecX2 = -0.9f;
                vecY2 = -0.4f;
                timer2 += Time.deltaTime;
                if (timer2 >= moveTime)
                {
                    b = Random.Range(1, 8);
                    timer2 = 0f;

                }
            }
        }

        if (hit6.collider!=null)
        {
            if (hit6.collider.tag == "wall")
            {
                if (b == 6)
                {
                    b = Random.Range(1, 6);
                }
            }
            if (hit6.collider.tag != "wall" && b == 6)
            {
                vecX2 = 0.8f;
                vecY2 = -0.8f;
                timer2 += Time.deltaTime;
                if (timer2 >= moveTime)
                {
                    b = Random.Range(1, 8);
                    timer2 = 0f;

                }
            }
        }

        if (hit10.collider!=null)
        {
            if (hit10.collider.tag == "wall")
            {
                if (b == 7)
                {
                    b = Random.Range(1, 7);
                }
            }
            if (hit10.collider.tag != "wall" && b == 7)
            {
                vecX2 = -0.4f;
                vecY2 = -0.9f;
                timer2 += Time.deltaTime;
                if (timer2 >= moveTime)
                {
                    b = Random.Range(1, 8);
                    timer2 = 0f;

                }
            }
        }
    }

    void lightSourceMain()
    {
        if (lightsourceBool==true)
        {
            mainLight.pointLightInnerRadius -= 0.1f;
            mainLight.pointLightOuterRadius -= 0.4f;
        }

    }
    void lightSourceEnemy()
    {
        if(lightsourceBool==false)
        {
            enemyLight.pointLightInnerRadius += 0.1f;
            enemyLight.pointLightOuterRadius += 0.2f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="mainLight")
        {
            StartCoroutine(changingPos());
            c = 0;
            lightSourceMain();
            lightsourceBool = false;
        }
        if (collision.gameObject.tag=="enemyLight")
        {
            StartCoroutine(changingPos());
            c = 1;
            lightSourceEnemy();
            lightsourceBool = true;
        }
    }
    IEnumerator changingPos()
    {
        yield return new WaitForSeconds(2);
        if (c == 0)
        {
            directionBool = false;
            a = 3;
            vecX2 = 0;
            vecY2 = 0;
        }
        else if (c == 1)
        {
            directionBool = true;
            b = 4;
            vecX2 = 0;
            vecY2 = 0;
        }
        StopCoroutine(changingPos());
    }
}
