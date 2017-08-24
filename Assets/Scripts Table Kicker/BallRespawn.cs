using UnityEngine;
using System.Collections;

public class BallRespawn : MonoBehaviour 
{

	public Rigidbody Ballrespawn;
	public Transform Spawn;

    public Vector3 LocalOrientation;

    public float thrust;

    public GameObject GameController;
    private GameController gameStatus;

   

	AudioSource audioWhistle;


	void Start()
	{
        audioWhistle = GetComponent<AudioSource>();

        gameStatus = GameController.GetComponent<GameController>();
	}

    void Update()
    {
        gameStatus = GameController.GetComponent<GameController>();
    }
        



	public void Respawn ()
	{
        print("GameStatus nach Respawn: " + gameStatus.gamefinished);
        if (!gameStatus.gamefinished)
        {

            //When called it respawns the ball at the position and with the rotation of empty object RespawnNorth or RespawnSouth
            Rigidbody ballInstance;



            transform.Rotate(0, Random.Range(-30, 30), 0);
            ballInstance = Instantiate(Ballrespawn, Spawn.position, Spawn.rotation) as Rigidbody;
            ballInstance.AddForce(Spawn.forward * thrust);
            audioWhistle.Play();

          




            //resets the rotation of the SpawnPoint
            transform.eulerAngles = (LocalOrientation);
        }
        else if (gameStatus.gamefinished)
        {
            print("Game has finished, no ballrespawn!");
        }
    		
	}
	
}