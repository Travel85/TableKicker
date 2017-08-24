using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CounterRed : MonoBehaviour
{

    //initializing the array for BlockRed
    public GameObject[] BlockRed;

    public float speed = 50.0f;
    private int BlockNumber = 0;



    // Use this for initialization
    void Start()
    {

        BlockRed = new GameObject[10];

        //finding the red Counter Blocks and storing them in an array; Blockred[0] = Counter-Block1" - Blockred[9] = "Counter-Block10"
        for (int i = 0; i < 10; i++)
        {
            BlockRed[i] = GameObject.Find("Counter-Block" + (i + 1));
        }


        //resetting the position of the blocks
        for (int i = 9; i >= 0; i--)
        {
            BlockRed[i].GetComponent<Rigidbody>().AddForce(-transform.forward * speed, ForceMode.VelocityChange);
        }
    }

    //when called one block moves south to visualize a goal
    public void Scoring ()
    {
        BlockRed[BlockNumber].GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.VelocityChange);
        BlockNumber++;

        if (BlockNumber >= 9)
        {
            BlockNumber = 0;
        }
    }
}