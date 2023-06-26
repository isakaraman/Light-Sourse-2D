using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterScript : MonoBehaviour
{    
    Vector3 vec;
    Rigidbody2D rigid;

    public float characterSpeed;  
    public float jumpSpeed;
    
    bool jumpBool = false;

    float horizontal;
    float jumpCounter=0f;

    public Text jumpText;

    public GameObject ball;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>(); 
    }
    void Update()
    {
        jump();
        move();
    }
    void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!jumpBool)
            {
                rigid.AddForce(new Vector2(0, jumpSpeed));
                jumpBool = true;
            }

        }
    }
    void move()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vec = new Vector3(horizontal * characterSpeed, rigid.velocity.y, 0);
        rigid.velocity = vec;   
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="plane")
        {
            jumpBool = false;
        }
        if (collision.gameObject.tag=="ball")
        {
            jumpCounter += 1;
            jumpText.text="Jump Count: "+jumpCounter;

            //if (Input.GetKeyDown(KeyCode.F))
            //{
            //    ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 50));
            //}
        }

    }
}
