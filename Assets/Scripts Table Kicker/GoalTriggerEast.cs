using UnityEngine;
using System.Collections;

public class GoalTriggerEast : MonoBehaviour 
{

	public GameObject Game_Controller;
    public GameController gameController;

	private BallRespawn ballRespawn;

	public GameObject SpawnScript;
    public string P2;

	void Start ()
	{
		ballRespawn = SpawnScript.GetComponent<BallRespawn>();
		gameController = Game_Controller.GetComponent<GameController>();
	}

    void Update ()
    {
    
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
	

           //call AddScore to add 1 point to P2
            gameController.AddScore("P1");

            gameController = Game_Controller.GetComponent<GameController>();
            if (!gameController.gamefinished)
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
