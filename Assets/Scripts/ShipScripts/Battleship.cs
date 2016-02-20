using UnityEngine;
using System.Collections;

public class Battleship : Ship {

    Battleship (int x, int z)
    {
        x_pos = x;
        z_pos = z;
    }

    // Use this for initialization
    void Start()
    {
        // init ship stats
        health = 10;
        power = 4;
        speed = 2;

        // build and position ship object
        prefab_location = "/Prefabs/Battleship";
        the_ship = (GameObject)Resources.Load(prefab_location);
        the_ship.transform.position = new Vector3(x_pos, water_height-1, z_pos);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
