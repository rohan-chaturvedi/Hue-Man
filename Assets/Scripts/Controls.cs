using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Controls : MonoBehaviour {
    public float speed = 0.5f;
    public float movespeed;
    public int color;
    public Rigidbody2D hm;
    private float startY;
    private float currentY;
    private float fixedY;
    public int score;
    public int lifetime;
    public int playtime;
    private Animator anim;


    // Use this for initialization


    void Start ()
    {
        hm = GetComponent<Rigidbody2D>();
        calibrate();
        anim = GetComponent<Animator>();

    }

    public IEnumerator calibrate()
    {
        yield return new WaitForSeconds(2);
        startY = Input.acceleration.y;//get initial device orientation
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.timeScale != 0)
        {
            //Accelorometer input
            currentY = Input.acceleration.y;//get raw sensor data
            if (startY == 0) startY = Input.acceleration.y;
            fixedY = currentY + Mathf.Abs(startY);//offset the value from sensor according to initial device orientation
            transform.Translate(0, fixedY, 0);


            //Keyboard input
            if (Input.GetKey(KeyCode.UpArrow))
            {
                hm.velocity = new Vector2(hm.velocity.x, movespeed);

            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                hm.velocity = new Vector2(hm.velocity.x, -movespeed);

            }

        }
        

        if(transform.position.y <= -4.5f)
        {
            transform.position = new Vector2(transform.position.x, -4.5f);
        }
        else if (transform.position.y >= 6.0f)
        {
            transform.position = new Vector2(transform.position.x, 6.0f);
        }

        if (color == 0)
        {
            anim.SetInteger("color", 0);
        }
        else if (color == 1)
        {
            anim.SetInteger("color", 1);
        }
        else if (color == 2)
        {
            anim.SetInteger("color", 2);
        }
        else if (color == 3)
        {
            anim.SetInteger("color", 3);
        }
    }
}
