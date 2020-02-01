using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Use this for initialization
    public KeyCode[] myKeys = new KeyCode[20];
    public string verticalName, horizontalName;
    public bool selected;
    float horizontalMovement, verticalMovement;
    Vector2 addvelocity;
    [SerializeField] float movementSpeed, jumpPower, maxSpeed = 5;
    Rigidbody rb;
    Vector2 maxXSpeed;
    bool isOnGround;
    [SerializeField] AudioClip jumpSoundEffect;
    Vector3 movingValue;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        addvelocity = new Vector2();
        rb = GetComponent<Rigidbody>();
        movingValue = new Vector3();
    }
    // Update is called once per frame
    void Update()
    {
        if (selected)
        {

            movingValue.x = Input.GetAxis(verticalName);
            movingValue.z = Input.GetAxis(horizontalName);
            movingValue *= (movementSpeed * Time.deltaTime);
            rb.position += movingValue;
            //addvelocity.x = horizontalMovement * movementSpeed * Time.deltaTime;
            //print(addvelocity.x);
            /*if (addvelocity.x > 0)
            {
                if (rb.velocity.x < maxSpeed)
                {
                    rb.velocity += addvelocity;
                }
                else
                {
                    rb.velocity = new Vector2(maxSpeed, rb.velocity.y);
                }
            }
            else if (addvelocity.x < 0)
            {

                if (rb.velocity.x > -maxSpeed)
                {
                    rb.velocity += addvelocity;
                }
                else
                {
                    rb.velocity = new Vector2(-maxSpeed, rb.velocity.y);
                }
            }*/
            //addvelocity.y = rb2d.velocity.y;
            /*if (rb.velocity.y < 0)
            {
                rb.gravityScale = 2;
            }
            else
            {
                rb.gravityScale = 1.5f;
            }*/
            //rb2d.velocity = addvelocity;
            /*if (Input.GetKeyDown(myKeys[0])&&isOnGround)
            {
                rb.AddForce(new Vector2(0, 7.5f), ForceMode2D.Impulse);
                //AudioSource.PlayClipAtPoint(jumpSoundEffect, new Vector2(0, 0));
                AudioSource.PlayClipAtPoint(jumpSoundEffect,transform.position);
                isOnGround = false;
            }*/
            //print(rb2d.velocity);

            for (int i = 0; i < 20; i++)
            {
                if (Input.GetKey(myKeys[i]))
                {
                    //print(i);
                }
            }

        }
    }
}
