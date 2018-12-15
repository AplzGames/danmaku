using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arcscript3 : MonoBehaviour {
    public GameObject bullet;
    public Rigidbody2D rb;
    public float speed;
    public int difficulty;
    public int danmaku;
    public int rotatedirection;
    public int isit;
    public int isdan;
    private float min;
    private float max;
    private float speeds;
    private float heights;




    //Vector3 pointA = new Vector3(0, 0, 0);
    //Vector3 pointB = new Vector3(1, 1, 1);

    // Use this for initialization
    void Start()
    {

        speeds = 5f;
        //adjust this to change how high it goes
        heights = 1f;


        difficulty = GameObject.Find("Player").GetComponent<PlayerMovement>().difficulty;





        //Script for trash danmaku
        //1 = easy. 2 = normal. 3 = hard, 4 = lunatic

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

    // Update is called once per frame
    void Update()
    {



        Vector3 pos = transform.position;
        //calculate what the new Y position will be
        float newY = Mathf.Sin(Time.time * speeds);
        //set the object's Y to the new calculated Y
        transform.position = new Vector3(pos.x, newY - 2, pos.z) * heights;



    }

    void Fire()
    {

        Instantiate(bullet, transform.position, transform.rotation);

    }
}
