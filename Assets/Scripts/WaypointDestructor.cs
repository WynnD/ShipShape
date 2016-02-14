using UnityEngine;
using System.Collections;


//HANDLES HOW WAYPOINTS ARE DESTROYED

public class WaypointDestructor : MonoBehaviour
{
	void Update ()
    {
	    if(Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Mouse1))
        {
            Destroy(this.gameObject);
        }
	}
}
