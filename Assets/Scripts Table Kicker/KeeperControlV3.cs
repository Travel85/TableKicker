using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	//boundary for keeper movement
    public float zMin, zMax, x_origin;
    
}

public class KeeperControlV3 : MonoBehaviour {

	private float spinrate = 1000.0f;
	public float moverate = 10.0f;
  

	public Boundary boundary;
    void Start ()
    {
       // Rigidbody.maxAngularVelocity = 1000.0f;
       
    }


	void FixedUpdate ()
		{
			//assigning horizontal input axis for spinning to the left and right
			float spinHorizontal = Input.GetAxis ("Horizontal_P1") * spinrate  *Time.deltaTime;

			//assigning  vertical input axis for moving up and down
			float moveVertical = Input.GetAxis ("Vertical_P1") * moverate;

            //Vector3 for moving up and down
			Vector3 movement = new Vector3 (0.0f, 0.0f, -moveVertical);
			GetComponent<Rigidbody>().velocity = movement;


            //Rotation for spinning to the left and right
			//GetComponent<Rigidbody> ().AddTorque (transform.forward * spinHorizontal, ForceMode.VelocityChange);
            GetComponent<Rigidbody>().AddTorque(transform.up * spinHorizontal, ForceMode.VelocityChange);

            //boundary for keeper movement
			GetComponent<Rigidbody> ().position = new Vector3 
			    (
				    boundary.x_origin, 
				    -0.156f, 
				    Mathf.Clamp (GetComponent<Rigidbody> ().position.z, boundary.zMin, boundary.zMax)
			    );
		}

}
