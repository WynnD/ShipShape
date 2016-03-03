using UnityEngine;
using System.Collections;
using System.Collections.Generic;


/* 
 * InitializeShips: Builds list of ships and places ships on board 
*/


public class IntializeShips : MonoBehaviour {

    const int SHIPS_PER_SIDE = 4; // change this to modify number of ships per side

    Queue<string> p1ships;
    Queue<string> p2ships;
    ShipPlacer shipPlacer;

	// Use this for initialization
	void Start () {
        p1ships = buildTempList(SHIPS_PER_SIDE);
        p2ships = buildTempList(SHIPS_PER_SIDE);
    }
	
	// Update is called once per frame
	void Update () {
	
	}


    Queue<string> buildTempList(int numShips) {
        // creates queue of numShips number of strings with value "Frigate"
        Queue<string> list = new Queue<string>(SHIPS_PER_SIDE);

        for (int i = 0; i < numShips; ++i) list.Enqueue("Frigate");
        return list;
    }
}
