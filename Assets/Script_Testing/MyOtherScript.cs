using UnityEngine;
using System.Collections;

public class MyOtherScript : MonoBehaviour
{
	public int gamma = 1;
	public int epsilon;

	public void Calculator (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log ("Summe: " + answer);
	}




}
