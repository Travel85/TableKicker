using UnityEngine;
using System.Collections;

public class Speed : MonoBehaviour {

    public float BallVelocity;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        var vel = GetComponent<Rigidbody>().velocity;
        BallVelocity = vel.magnitude;
        Debug.Log("Ballvelocity is " + BallVelocity );
	}
}
