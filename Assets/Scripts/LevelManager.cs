using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    //KEEPS TRACK OF RANDOM GOINGS ON IN THE LEVEL

    public bool p1Turn;
    public GameObject[] p1Ships; //active p1 ships in the scene
    public GameObject[] p2Ships; //active p2 ships in the scene



	void Start ()
    {
        p1Turn = true;
        p1Ships = GameObject.FindGameObjectsWithTag("P1Ship");
        p2Ships = GameObject.FindGameObjectsWithTag("P2Ship");
    }
	

	void Update ()
    {
        //Turn System
	    if(p1Turn == true)
        {
            //do all the things that are necessary for p1 to be active.
            //Debug.Log("P1 Turn");
        }
        else
        {
            //do all the things that are necessary for p2 to be active.
            //Debug.Log("P2 Turn");
        }









        //Winning or Losing
        if (p1Ships.Length <= 0)
        {
            //P1 lost the game.
            Debug.Log("P1 Lost the Game.");
        }
        if (p1Ships.Length <= 0)
        {
            //P1 lost the game.
            Debug.Log("P2 Lost the Game.");
        }
    }
}
