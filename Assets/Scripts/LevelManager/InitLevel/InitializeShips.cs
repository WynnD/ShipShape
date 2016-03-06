using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;


/* 
 * InitializeShips: Builds list of ships and places ships on board 
*/


public class InitializeShips : LevelManager
{

    const int SHIPS_PER_SIDE = 4; // change this to modify number of ships per side

    public Queue<string> p1ships;
    public Queue<string> p2ships;
    MouseClickedMe click;

    // Use this for initialization
    void Start()
    {
        p1ships = buildTempList(SHIPS_PER_SIDE);
        p2ships = buildTempList(SHIPS_PER_SIDE);
        placeShipsFromList(p1ships, -75, -75, false);
        placeShipsFromList(p2ships, 75, 75, true);
    }

    // Update is called once per frame
    void Update()
    {

    }


    Queue<string> buildTempList(int numShips)
    {
        // creates queue of numShips number of strings with value "Frigate"
        Queue<string> list = new Queue<string>(numShips);

        for (int i = 0; i < numShips; ++i)
            list.Enqueue("Frigate");
        return list;
    }


    private void placeShipsFromList(Queue<string> ship_list, int x_coord, int z_coord, bool turn180)
    {
        if (ship_list.Count == 0) // if we are out of ships, then stop
        {
            return;
        }
        else // otherwise, keep making ships
        {
            string ship = ship_list.Dequeue();
            string prefab_filename;
            Object prefab;
            switch (ship)
            {
                default:
                    prefab_filename = "TestShip_2.prefab";
                    break;
            }
            prefab = AssetDatabase.LoadAssetAtPath(
                "Assets/Prefabs/Ships/"+prefab_filename, 
                typeof(GameObject));

            if (prefab)
                Instantiate(prefab, new Vector3(x_coord, 2.5F, z_coord), 
                    (turn180?Quaternion.Euler(new Vector3(0,180,0)):Quaternion.identity)); // this checks if we are turning the ship 180 degrees, and does so if true
            else
                Debug.Log("Could not instantiate object, given ship type " + ship + " with filename " + prefab_filename);


            placeShipsFromList(ship_list, x_coord + 10, z_coord + 10, turn180); // recursive call to build more ships 10 units to the right and up from last ship
        }
    }
}