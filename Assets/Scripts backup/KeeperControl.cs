using UnityEngine;
using System.Collections;

public class KeeperControl : MonoBehaviour 
{

	public float amount = 50f;
	
	void FixedUpdate () 
	{
		//definition of axis 
		float v = Input.GetAxis ("Horizontal") * amount * Time.deltaTime;
		float h = Input.GetAxis ("Vertical") * amount * Time.deltaTime;

		//Rotation positive/negative
		GetComponent<Rigidbody>().AddTorque (transform.right * v, ForceMode.VelocityChange);

		//Translation positive/negative
		GetComponent<Rigidbody> ().AddForce (transform.right * h, ForceMode.VelocityChange);
	}
}
