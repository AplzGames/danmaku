using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public GameObject bullet;
    public Rigidbody2D rb;
    public float speed;
    public int difficulty;
    public int danmaku;
    public int rotatedirection;
    public int isit;
    public int isdan;

    
    

    Vector3 pointA = new Vector3(0, 0, 0);
    Vector3 pointB = new Vector3(1, 1, 1);

    // Use this for initialization
    void Start () {

        difficulty = GameObject.Find("Player").GetComponent<PlayerMovement>().difficulty;

        isit = GameObject.Find("Boss1").GetComponent<Boss1Fight>().d;

        isdan = GameObject.Find("Boss1").GetComponent<Boss1Fight>().dan;

        if (isit == 1)
        {
            difficulty = 1;
        }

        if (isdan == 1)
        {
            danmaku = 1;
        }
        else if (isdan == 2)
        {
            danmaku = 2;
        }


        //Script for trash danmaku
        //1 = easy. 2 = normal. 3 = hard, 4 = lunatic
        if (danmaku == 1 || danmaku == 2)//Spiral Danmaku
        {
            if (difficulty == 1)
            {
                InvokeRepeating("Fire", 1f, 0.5f);
            }
            else if (difficulty == 2)
            {
                InvokeRepeating("Fire", 1f, 0.12f);
            }
            else if (difficulty == 3)
            {
                InvokeRepeating("Fire", 1f, 0.08f);
            }
            else if (difficulty == 4)
            {
                InvokeRepeating("Fire", 1f, 0.02f);
            }
        }
        
    }
	
	// Update is called once per frame
	void Update () {
        if (rotatedirection == 1)
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }
        else if (rotatedirection == 2)
        {
            transform.Rotate(Vector3.forward * -speed * Time.deltaTime);
        }


        if (danmaku == 2){

            speed++;

            if (difficulty == 4 && speed == 500)
            {
                speed -= 500;
            }
            else if (difficulty == 3 && speed == 230)
            {

                speed -= 1000;

            }
            else if (difficulty == 2 && speed >= 690)
            {

                speed -= 1200;

            }


        }
    }

    void Fire()
    {
        if (danmaku == 1 || danmaku == 2) 
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
