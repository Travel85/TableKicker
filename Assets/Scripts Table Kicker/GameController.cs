using UnityEngine;
using System.Collections;


public class GameController : MonoBehaviour 
{

	public GUIText scoreP1;
	public GUIText scoreP2;
    public GUIText StatusText;
    public GUIText GameVersion;

	private int score1;
	private int score2;

    private GameObject TempBall;
    public GameObject CountRed;
    public GameObject CountYellow;

    private CounterRed counterRed;
    private CounterYellow counterYellow;

    private InsertBall insertBall;

    public AudioClip whistle2;

    bool soundplayed;
	

    public bool gamefinished;

	// Use this for initialization
	void Start () 
	{
       
        //resets the player score for P1 and P2

      // GetComponent<AudioSource>().Play();

        soundplayed = false;
   
		score1 = 0;
		score2 = 0;

        gamefinished = false;

		UpdateScore_P1 ();
        UpdateScore_P2 ();

        StatusText.text = "Press 'B' to start game!";

        GameVersion.text = "Version 1.0";

        insertBall = GetComponent<InsertBall>();
        counterRed = CountRed.GetComponent<CounterRed>();
        counterYellow = CountYellow.GetComponent<CounterYellow>();
	}
	
	// Update is called once per frame
	void Update () 
	{
        //Assigning key for resetting game
		if (Input.GetKeyDown (KeyCode.R))
		{
          
            Application.LoadLevel (Application.loadedLevel);
           
		}

        //Destroys the Ball and calls the InsertBall function
        if (Input.GetKeyDown(KeyCode.B) && !gamefinished)
        {
           TempBall= GameObject.FindGameObjectWithTag("Ball");
           if (TempBall != null)
           {
               Destroy(TempBall);
           }
           
      
           StatusText.text = "";
         
           insertBall.RandomInsert();
        }

        //check if Player 1 or Player 2 wins
        if (score1 == 10 || score2 == 10)
        {
            gamefinished = true;
            print("Gamestatus nach Sieg: "+gamefinished);
       
            if (!soundplayed)
            {
                AudioSource.PlayClipAtPoint(whistle2, transform.position);
                soundplayed = true;
            }
            
            

            if (score1 > score2)
            { 
                StatusText.text = "Player 1 has won! Press 'R' to restart Game."; 
            }
            else
            {
                StatusText.text = "Player 2 has won! Press 'R' to restart Game."; 
            }
          

			
        }
       
      
       

        //Quitting the Game
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
	}

    //AddScore function
    //receives string "P1" or "P2" and add one point to P1 or P2 and then calls UpdateScore-function for P1 or P2
    //the counterRed or counterYellow is called to move the yellow or red block to visualize a goal
	public void AddScore (string ScoreName)
	{
        string tempScore = "";
        tempScore = ScoreName;
     
        if (tempScore == "P1")
        {
           
            score1 += 1;
            UpdateScore_P1 ();
            counterRed.Scoring();
        }
        else 
        {
         
            score2 += 1;
            UpdateScore_P2 ();
            counterYellow.Scoring();
        }
     
      
	}

    //Update-Score Function for P1
    //When called it writes the score to GUIText scoreP1
	void UpdateScore_P1 ()
	{
		scoreP1.text = "Score P1: " + score1;
	}

    //Update-Score Function for P2
    //When called it writes the score to GUIText scoreP2
    void UpdateScore_P2()
    {
        scoreP2.text = "Score P2: " + score2;
    }

   
 
}