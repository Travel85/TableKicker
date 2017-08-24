using UnityEngine;
using System.Collections;

public class AddTorque : MonoBehaviour {

	public float amount = 50f;

	void FixedUpdate () 
	{

		float v = Input.GetAxis ("Horizontal") * amount * Time.deltaTime;


		GetComponent<Rigidbody>().AddTorque (transform.right * v, ForceMode.VelocityChange);

	}
}
