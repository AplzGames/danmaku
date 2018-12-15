using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour {

    public Transform target;
    public float far;

	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        // Spin the object around the world origin at 20 degrees/second.
        transform.RotateAround(Vector3.zero, Vector3.forward, 100 * Time.deltaTime);
        
    }
}
