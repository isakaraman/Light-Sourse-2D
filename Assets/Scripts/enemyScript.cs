using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    float vecX = 0, vecY = 0, vecX2 = 0, vecY2 = 0, timer1,timer2;
    int a,b,c;
    public float minX, maxX, minY, maxY;
    bool hitB1, hitB2, hitB3, hitB4, hitB5, hitB6, hitB7, hitB8, hitB9, hitB10,hitB11,hitB12,directionBool=true;

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

        RaycastHit2D hit1 = Physics2D.Raycast(new Vector2(transform.position.x + 0.3f, transform.position.y), transform.TransformDirection(new Vector3(1f, 0, 0)),1f);
        RaycastHit2D hit2 = Physics2D.Raycast(new Vector2(transform.position.x + 0.2f, transform.position.y + 0.2f), transform.TransformDirection(new Vector3(1f, 0.4f, 0)), 1.1f);
        RaycastHit2D hit6 = Physics2D.Raycast(new Vector2(transform.position.x + 0.2f, transform.position.y + -0.2f), transform.TransformDirection(new Vector3(0.8f, -0.8f, 0)), 1.15f);
        RaycastHit2D hit7 = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y - 0.3f), transform.TransformDirection(new Vector3(0, -1f, 0)), 1f);
        RaycastHit2D hit8 = Physics2D.Raycast(new Vector2(transform.position.x + -0.2f, transform.position.y + -0.2f), transform.TransformDirection(new Vector3(-0.4f, -1f, 0)), 1.1f);
        RaycastHit2D hit4 = Physics2D.Raycast(new Vector2(transform.position.x + -0.2f, transform.position.y + 0.2f), transform.TransformDirection(new Vector3(-0.8f, 0.8f, 0)), 1.15f);
        RaycastHit2D hit9 = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y + 0.3f), transform.TransformDirection(new Vector3(0.4f, 1f, 0)), 1.1f);




        if (hit1 == true && hit1.transform.gameObject.tag == "wall" && !hitB1)
        {
            if (a == 1)
            {
                a = Random.Range(2, 8);
                hitB1 = true;
            }
            else
            {
                hitB2 = false; hitB3 = false; hitB4 = false; hitB5 = false; hitB11 = false; hitB12 = false;
            }
        }
        if (hit1 == false && a == 1)
        {
            vecX = 1f;
            vecY = 0;
            timer1 += Time.deltaTime;
            if (timer1 >= 1f)
            {
                a = Random.Range(1, 8);
                timer1 = 0f;

            }
        }

        if (hit2 == true && hit2.transform.gameObject.tag == "wall" && !hitB2)
        {
            if (a == 2)
            {
                a = Random.Range(3, 8);
                hitB2 = true;
            }
            else
            {
                hitB1 = false; hitB3 = false; hitB4 = false; hitB5 = false; hitB11 = false; hitB12 = false;
            }

        }
        if (hit2 == false && a == 2)
        {
            vecX = 0.9f;
            vecY = 0.4f;
            timer1 += Time.deltaTime;
            if (timer1 >= 1f)
            {
                a = Random.Range(1, 8);
                timer1 = 0f;

            }
        }

        if (hit6 == true && hit6.transform.gameObject.tag == "wall" && !hitB3)
        {
            if (a == 3)
            {
                a = Random.Range(4, 8);
                hitB3 = true;
            }
            else
            {
                hitB1 = false; hitB2 = false;  hitB4 = false; hitB5 = false; hitB11 = false; hitB12 = false;
            }
        }
        if (hit6 == false && a == 3)
        {
            vecX = 0.8f;
            vecY = -0.8f;
            timer1 += Time.deltaTime;
            if (timer1 >= 1f)
            {
                a = Random.Range(1, 8);
                timer1 = 0f;

            }
        }

        if (hit7 == true && hit7.transform.gameObject.tag == "wall" && !hitB4)
        {
            if (a == 4)
            {
                a = Random.Range(1, 4);
                hitB4 = true;
            }
            else
            {
                hitB1 = false; hitB2 = false; hitB3 = false; hitB5 = false; hitB11 = false; hitB12 = false;
            }

        }
        if (hit7 == false && a == 4)
        {

            vecX = 0f;
            vecY = -1f;
            timer1 += Time.deltaTime;
            if (timer1 >= 1f)
            {
                a = Random.Range(1, 8);
                timer1 = 0f;

            }
        }

        if (hit8 == true && hit8.transform.gameObject.tag == "wall" && !hitB5)
        {
            if (a == 5)
            {
                a = Random.Range(1, 5);
                hitB5 = true;
            }
            else
            {
                hitB1 = false; hitB2 = false; hitB3 = false; hitB4 = false; hitB11 = false; hitB12 = false;
            }

        }
        if (hit8 == false && a == 5)
        {

            vecX = -0.4f;
            vecY = -0.9f;
            timer1 += Time.deltaTime;
            if (timer1 >= 1f)
            {
                a = Random.Range(1, 8);
                timer1 = 0f;

            }
        }

        if (hit4 == true && hit4.transform.gameObject.tag == "wall" && !hitB11)
        {
            if (a == 6)
            {
                a = Random.Range(1, 6);
                hitB11 = true;
            }
            else
            {
                hitB1 = false; hitB2 = false; hitB3 = false; hitB4 = false; hitB5 = false; hitB12 = false;
            }

        }
        if (hit4 == false && a == 6)
        {
            vecX = -0.8f;
            vecY = 0.8f;
            timer1 += Time.deltaTime;
            if (timer1 >= 1f)
            {
                a = Random.Range(1, 8);
                timer1 = 0f;

            }
        }

        if (hit9 == true && hit9.transform.gameObject.tag == "wall" && !hitB12)
        {
            if (a == 7)
            {
                a = Random.Range(1, 7);
                hitB12 = true;
            }
            else
            {
                hitB1 = false; hitB2 = false; hitB3 = false; hitB4 = false; hitB5 = false; hitB11 = false;
            }

        }
        if (hit9 == false && a == 7)
        {
            vecX = 0.4f;
            vecY = 0.9f;
            timer1 += Time.deltaTime;
            if (timer1 >= 1f)
            {
                a = Random.Range(1, 8);
                timer1 = 0f;

            }
        }

        if (hit1.collider != null && hit1.collider.gameObject.tag == "mainLight"||
            hit2.collider != null && hit2.collider.gameObject.tag == "mainLight" || 
            hit6.collider != null && hit6.collider.gameObject.tag == "mainLight" ||
            hit7.collider != null && hit7.collider.gameObject.tag == "mainLight" ||
            hit8.collider != null && hit8.collider.gameObject.tag == "mainLight" || 
            hit4.collider != null && hit4.collider.gameObject.tag == "mainLight" ||
            hit9.collider != null && hit9.collider.gameObject.tag == "mainLight")
        {
            StartCoroutine(changingPos());
            vecX = 0;
            vecY = 0;
            c = 0;
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
        RaycastHit2D hit10 = Physics2D.Raycast(new Vector2(transform.position.x , transform.position.y + -0.3f), transform.TransformDirection(new Vector3(-0.4f, -0.9f, 0)), 1.1f);
     
        if (hit2 == true && hit2.transform.gameObject.tag == "wall" && !hitB6)
        {
            if (b == 1)
            {
                b = Random.Range(2, 8);
                hitB6 = true;
            }
            else
            {
                hitB7 = false; hitB8 = false; hitB9 = false; hitB10 = false; hitB12 = false; hitB11 = false;

            }

        }
        if (hit2 == false && b == 1)
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

        if (hit3 == true && hit3.transform.gameObject.tag == "wall" && !hitB7)
        {

            if (b == 2)
            {
                b = Random.Range(3, 8);
                hitB7 = true;
            }
            else
            {
                hitB6 = false; hitB8 = false; hitB9 = false; hitB10 = false; hitB12 = false; hitB11 = false;
            }
        }
        if (hit3 == false && b == 2)
        {
            vecX2 = 0f;
            vecY2 = 1f;

            timer2 += Time.deltaTime;
            if (timer2 >= 1f)
            {
                b = Random.Range(1, 8);
                timer2 = 0f;

            }

        }

        if (hit4 == true && hit4.transform.gameObject.tag == "wall" && !hitB8)
        {
            if (b == 3)
            {
                b = Random.Range(4, 8);
                hitB8 = true;
            }
            else
            {
                hitB6 = false; hitB7 = false; hitB9 = false; hitB10 = false; hitB12 = false; hitB11 = false;
            }

        }
        if (hit4 == false && b == 3)
        {
            vecX2 = -0.8f;
            vecY2 = 0.8f;
            timer2 += Time.deltaTime;
            if (timer2 >= 1f)
            {
                b = Random.Range(1, 8);
                timer2 = 0f;

            }
        }

        if (hit5 == true && hit5.transform.gameObject.tag == "wall" && !hitB9)
        {
            if (b == 4)
            {
                b = Random.Range(5, 8);
                hitB9 = true;
            }
            else
            {
                hitB6 = false; hitB7 = false; hitB8 = false; hitB10 = false; hitB12 = false; hitB11 = false;
            }

        }
        if (hit5 == false && b == 4)
        {
            vecX2 = -1f;
            vecY2 = 0f;
            timer2 += Time.deltaTime;
            if (timer2 >= 1f)
            {
                b = Random.Range(1, 8);
                timer2 = 0f;

            }
        }

        if (hit8 == true && hit8.transform.gameObject.tag == "wall" && !hitB10)
        {
            if (b == 5)
            {
                b = Random.Range(1, 5);
                hitB10 = true;
            }
            else
            {
                hitB6 = false; hitB7 = false; hitB8 = false; hitB9 = false; hitB12 = false; hitB11 = false;
            }

        }
        if (hit8 == false && b == 5)
        {

            vecX2 = -0.9f;
            vecY2 = -0.4f;
            timer2 += Time.deltaTime;
            if (timer2 >= 1f)
            {
                b = Random.Range(1, 8);
                timer2 = 0f;

            }
        }

        if (hit6 == true && hit6.transform.gameObject.tag == "wall" && !hitB12)
        {
            if (b == 6)
            {
                b = Random.Range(1, 6);
                hitB12 = true;
            }
            else
            {
                hitB6 = false; hitB7 = false; hitB8 = false; hitB9 = false; hitB10 = false; hitB11 = false;
            }
        }
        if (hit6 == false && b == 6)
        {
            vecX2 = 0.8f;
            vecY2 = -0.8f;
            timer2 += Time.deltaTime;
            if (timer2 >= 1f)
            {
                b = Random.Range(1, 8);
                timer2 = 0f;

            }
        }

        if (hit10 == true && hit10.transform.gameObject.tag == "wall" && !hitB11)
        {
            if (b == 7)
            {
                b = Random.Range(1, 7);
                hitB11 = true;
            }
            else
            {
                hitB6 = false; hitB7 = false; hitB8 = false; hitB9 = false; hitB10 = false; hitB12 = false;
            }
        }
        if (hit10 == false && b == 7)
        {
            vecX2 = -0.4f;
            vecY2 = -0.9f;
            timer2 += Time.deltaTime;
            if (timer2 >= 1f)
            {
                b = Random.Range(1, 8);
                timer2 = 0f;

            }
        }

        if (hit2.collider != null && hit2.collider.gameObject.tag == "enemyLight" ||
     hit3.collider != null && hit3.collider.gameObject.tag == "enemyLight" ||
     hit4.collider != null && hit4.collider.gameObject.tag == "enemyLight" ||
     hit5.collider != null && hit5.collider.gameObject.tag == "enemyLight" ||
     hit8.collider != null && hit8.collider.gameObject.tag == "enemyLight" ||
     hit6.collider != null && hit6.collider.gameObject.tag == "enemyLight" ||
     hit10.collider != null && hit10.collider.gameObject.tag == "enemyLight")
        {
            StartCoroutine(changingPos());
            vecX2 = 0;
            vecY2 = 0;
            c = 1;
        }
    }
    IEnumerator changingPos()
    {
        yield return new WaitForSeconds(2);
        if (c==0)
        {
            directionBool = false;
            a = 3;
        }
        else if(c==1)
        {
            directionBool = true;
            b = 4;
        }
        StopCoroutine(changingPos());
    }
}
