using UnityEngine;
using System.Collections;

[System.Serializable]
public class KeeperControlV4 : MonoBehaviour 
{


  //  public Boundary boundary;
   // private Rigidbody rb, rc;

   // private float rotationZ = 0f;
    //private float sensitivityZ = 50.0f;
 
    public float spinrate = 10.0f;
    public float moverate = 10.0f;


	// Use this for initialization
	void Start () 
    {
     //   rb = GetComponent<Rigidbody>();
     //   rc = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        //assigning horizontal input axis for spinning to the left and right
        
        //float spinHorizontal = Input.GetAxis("Horizontal_P1");

        //assigning  vertical input axis for moving up and down
        //float moveVertical = Input.GetAxis("Vertical_P1");

        //Vector3 for moving up and down

      

        //Vector3 movement = new Vector3 (0.0f, 0.0f, -moveVertical);
        //rb.MovePosition(transform.position + movement * moverate * Time.deltaTime);

        //Vector3 spinning = new Vector3(0.0f, 0.0f, spinHorizontal);

        // GetComponent<Rigidbody>().AddTorque(transform.up * -spinHorizontal, ForceMode.VelocityChange);

        //Quaternion deltaRotation = Quaternion.Euler(spinning * spinrate * Time.deltaTime);
        //rc.MoveRotation(rb.rotation * deltaRotation);



        //transform.Rotate(Vector3.up * spinHorizontal * spinrate * Time.deltaTime);
        //transform.Translate(Vector3.up * -moveVertical * moverate * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            //rotationZ = Mathf.Clamp(rotationZ, -90, 90);
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, -90);
            //rotationZ += Input.GetButtonDown("A") * sensitivityZ;
        }
        else if (Input.GetKey("d"))
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 90);
        }

        else 
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 0);
        }

       
       


       // rotationZ += Input.GetAxis("Horizontal_P1") * sensitivityZ;
        //rotationZ = Mathf.Clamp(rotationZ, -90, 90);

        //transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, -rotationZ);


        /*
         private float rotationZ = 0f;
         private float sensitivityZ = 2f;
 
         void lockedRotation()
         {
            rotationZ += Input.GetAxis("Mouse X") * sensitivityZ;
            rotationZ = Mathf.Clamp (rotationZ, -90, 90);
             
             transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, -rotationZ);
         }
         * */

    }
}

