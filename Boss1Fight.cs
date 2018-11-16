using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Fight : MonoBehaviour {

    public int health;
    public GameObject danmaku1;
    public GameObject danmaku2;
    
    public int speed;
    private int time;

    public int d;
    public int dan;
	// Use this for initialization
	void Start () {

        d = 1;
        //filler
        Instantiate(danmaku2, transform.position, transform.rotation);


	}
	
	// Update is called once per frame
	void Update () {
        time++;//set a timer for the fight

        

        if (health == 900)
        {
            Destroy(GameObject.FindWithTag("danmaku"));
            d = 0;
            Instantiate(danmaku1, transform.position, transform.rotation);
            health--;

        }
        if (health == 699)//700
        {


            Destroy(GameObject.FindWithTag("danmaku"));
            d = 1;
            //filler
            Instantiate(danmaku2, transform.position, transform.rotation);

           
            health--;

        }
        if (health == 599)
        {
            Destroy(GameObject.FindWithTag("danmaku"));
            d = 0;
            dan = 1;
            Instantiate(danmaku2, transform.position, transform.rotation);
            health--;

        }
        if (health == 399)
        {


            Destroy(GameObject.FindWithTag("danmaku"));
            d = 1;
            dan = 2;
            Instantiate(danmaku2, transform.position, transform.rotation);
            health--;


        }
        if (health == 299)
        {

            Destroy(GameObject.FindWithTag("danmaku"));
            d = 0;
            dan = 2;
            Instantiate(danmaku2, transform.position, transform.rotation);
            health--;



        }
        if (health == 0)
        {
            Destroy(GameObject.FindWithTag("danmaku"));
            Destroy(gameObject);

        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "shot")
        {

            health --;
        }
    }
}
