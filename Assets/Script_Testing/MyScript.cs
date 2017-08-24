using UnityEngine;
using System.Collections;

public class MyScript : MonoBehaviour {

	private int alpha = 0;
	public int beta = 1;

	public GameObject otherGameObject;

	private MyOtherScript myOtherScript;
	private AnotherScript anotherScript;


	//initialising the scripts;
	void Awake () 
	{
		myOtherScript = GetComponent<MyOtherScript>();
		anotherScript = otherGameObject.GetComponent<AnotherScript>();

	}

	// Use this for initialization
	void Start () 
	{
		myOtherScript.Calculator(alpha, myOtherScript.gamma);
		Debug.Log ("The player died " + anotherScript.playerDeaths + " times");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
