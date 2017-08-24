using UnityEngine;
using System.Collections;

public class InsertBall : MonoBehaviour {

    public GameObject SpawnPointNorth;
    public GameObject SpawnPointSouth;

  

    private BallRespawn spawnScriptNorth;
    private BallRespawn spawnScriptSouth;


 

	// Use this for initialization
	void Start () 
    {
	    spawnScriptNorth = SpawnPointNorth.GetComponent<BallRespawn>();
        spawnScriptSouth = SpawnPointSouth.GetComponent<BallRespawn>();
     
	}

    //when called after pressing 'B', it decides whether the ball respawns at the north or south respawn point
    public void RandomInsert()
    {
        int number = 0;
        number = Random.Range(1,3);
        

        if (number == 1)
        {
            spawnScriptNorth.Respawn();
        }
        else
        {
            spawnScriptSouth.Respawn();
        }
    }
}
