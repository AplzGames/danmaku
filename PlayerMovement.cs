using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float moveinput;
    public float moveinputy;
    public float movespeed;
    public int difficulty;

    public float moveSpeed = 3f;
    public Rigidbody2D rb;
    private int timer;
    public GameObject shot;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        moveinput = Input.GetAxis("Horizontal");
        moveinputy = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(moveinput * movespeed, moveinputy * movespeed);

        if (Input.GetKey(KeyCode.Space))
        {

            timer++;

            if (timer == 25)
            {
                Instantiate(shot, transform.position, transform.rotation);
                timer -= 25;
            }


        }

    }

    void Fire()
    {
        Instantiate(shot, transform.position,transform.rotation);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
    }


}
