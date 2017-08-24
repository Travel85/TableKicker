using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CounterYellow : MonoBehaviour 
{

    //initializing the array for BlockRed
    public GameObject[] BlockYellow;

    public float speed = 50.0f;
    private int BlockNumber = 0;



    // Use this for initialization
    void Start()
    {

        BlockYellow = new GameObject[10];

        //finding the yellow Counter Blocks and storing them in an array; Blockyelloq[0] = YCounter-Block1" - Blockyellow[9] = "YCounter-Block10"
        for (int i = 0; i < 10; i++)
        {
            BlockYellow[i] = GameObject.Find("YCounter-Block" + (i + 1));
        }


        //resetting the position of the blocks
        for (int i = 9; i >= 0; i--)
        {
            BlockYellow[i].GetComponent<Rigidbody>().AddForce(-transform.forward * speed, ForceMode.VelocityChange);
        }
    }

    //when called one block moves south to visualize a goal
    public void Scoring()
    {
        BlockYellow[BlockNumber].GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.VelocityChange);
        BlockNumber++;

        if (BlockNumber >= 9)
        {
            BlockNumber = 0;
        }
    }
}
