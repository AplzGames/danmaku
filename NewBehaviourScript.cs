using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {


    public int speed;
    public Rigidbody2D rb;
    public Collider2D collider;


	// Use this for initialization
	void Start () {

        rb.AddForce(transform.up * speed);
        Invoke("Destroyit", 4.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    
    void Destroyit()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {

            Destroy(gameObject);

        }
    }
}
