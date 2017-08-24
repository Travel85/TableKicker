using UnityEngine;
using System.Collections;

public class KeeperControlV2 : MonoBehaviour {

	public float moveSpeed = 10f;
	public float turnSpeed = 50f;
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		//translation to the left
		if (Input.GetKey (KeyCode.W)) 
			transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

		//translation to the right
		if (Input.GetKey (KeyCode.S)) 
			transform.Translate(-Vector3.right * moveSpeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.A))
			transform.Rotate (Vector3.left, -turnSpeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.D))
			transform.Rotate (Vector3.left, turnSpeed * Time.deltaTime);
		 
	}
}
