using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2Fight : MonoBehaviour {

    // Use this for initialization
    public int health;
    public GameObject danmaku1;
    public GameObject danmaku2;
    public GameObject danmaku3;
    public GameObject danmaku4;
    public GameObject danmaku5;
    public GameObject danmaku6;
    private GameObject player;



    public int speed;
    private int time;

    public int d;
    public int dan;
    // Use this for initialization
    void Start()
    {

        d = 1;
        //filler
        player = GameObject.Find("Player");


    }

    // Update is called once per frame
    void Update()
    {
        time++;//set a timer for the fight



        if (health == 900)
        {
            Destroy(GameObject.FindWithTag("danmaku"));
            d = 0;
            danmaku1.gameObject.SetActive(true);
            Instantiate(danmaku2, transform.position, transform.rotation);
            health--;

        }
        if (health == 699)//700
        {


            Destroy(GameObject.FindWithTag("danmaku"));
            d = 1;
            //filler
            Instantiate(danmaku2, transform.position, transform.rotation);
            Instantiate(danmaku3, transform.position, transform.rotation);


            health--;

        }
        if (health == 599)
        {
            Destroy(GameObject.FindWithTag("danmaku"));
            d = 0;
            dan = 1;
            Instantiate(danmaku4, player.transform.position, transform.rotation);
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
            danmaku3.gameObject.SetActive(true);
            danmaku5.gameObject.SetActive(true);

            health--;



        }
        if (health == 1)
        {
            Destroy(GameObject.FindWithTag("danmaku"));
            Destroy(GameObject.FindWithTag("bullet"));
            Destroy(danmaku3.gameObject);
            Destroy(danmaku5.gameObject);
            danmaku6.gameObject.SetActive(true);
            
            health--;
        }
        if (health == -200)
        {
            Destroy(GameObject.FindWithTag("danmaku"));
            Destroy(gameObject);

        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "shot")
        {

            health--;
        }
    }
}
