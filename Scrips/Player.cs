using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
   
    public float Speed;
    private Rigidbody2D rig;
    public float JumpForce;
    public bool isJumping;
    public bool doubleJump;
    private Animator anim;
    public Button GameOver;
    
   
    Stopwatch timer = new Stopwatch();
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }
    void Move()
    {
        Vector3 moviment = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += moviment * Time.deltaTime * Speed;

        if(Input.GetAxis("Horizontal") > 0f)
        {
            anim.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if (Input.GetAxis("Horizontal") < 0f)
        {
            anim.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
        if (Input.GetAxis("Horizontal") == 0f)
        {
            anim.SetBool("walk", false);
        }

    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if(!isJumping)
            {
                rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                doubleJump = true;
            }
            else
            {
                if (doubleJump)
                {
                    rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                    doubleJump = false;
                }
            }
           
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.layer == 8)
        {
           
            timer.Stop();
            isJumping = false;
            var tempo = timer.ElapsedMilliseconds;
           /* 
            if(unchecked((int) tempo) >= 1500)
            {
                print("Morreu");
                GameOver.gameObject.active = true;
               
            }
           */
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
   
        if (collision.gameObject.layer == 8)
        {

            isJumping = true;
            timer.Start();
        }
       
    }

}
