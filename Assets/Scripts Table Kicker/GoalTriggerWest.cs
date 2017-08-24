using UnityEngine;
using System.Collections;

public class GoalTriggerWest : MonoBehaviour 
{
    public GameObject Game_ControllerW;
    public GameController gameControllerW;

    public string P1;

	private BallRespawn ballRespawn;
	
	public GameObject SpawnScript;
	
	void Start ()
	{
		ballRespawn = SpawnScript.GetComponent<BallRespawn>();
        gameControllerW = Game_ControllerW.GetComponent<GameController>();
	}


	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Ball")) 
		{
			
		}
	}
	
	void OnTriggerStay (Collider other)
	{


		if (other.gameObject.CompareTag ("Ball")) 
		{
			
			Destroy (other.gameObject);
			

            //call AddScore to add 1 point to P1
            gameControllerW.AddScore("P2");

            gameControllerW = Game_ControllerW.GetComponent<GameController>();
            if (!gameControllerW.gamefinished)
            {
                //call Respawn()
                ballRespawn.Respawn();
            }
            else
            {
                print("Game has finished, no respawn!");
				ballRespawn.enabled = false;
            }

		}
	}
	
	void OnTriggerExit (Collider other)
	{
		if (other.gameObject.CompareTag ("Ball")) 
		{
		
		}
	}
}
