using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour
{


    //HANDLES SHIP MOVEMENT AS WELL AS POINTING AT WAYPOINTS


    public MouseClickedMe clickedScript;
    public GameObject waypoint;
    public float rotSpeed;
    public GameObject wayPointPrefab;
    public float movementDistance;
    public float moveSpeed;

    private Transform target;


    void Start ()
    {
        clickedScript = this.GetComponent<MouseClickedMe>(); // the ClickedMeScript
	}
	

	void Update ()
    {
        if (clickedScript.shipEnabled == true) // if the ship is selected
        {
            if (GameObject.Find("Waypoint(Clone)") != null) // if there is a waypoint in the scene
            {
                target = GameObject.Find("Waypoint(Clone)").transform; // find the new waypoint
                RotateTowardWaypoint();
                if(movementDistance >= 0)
                {
                    transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
                    movementDistance -= 1 * Time.deltaTime;  
                }
            }
        }
	}

    void RotateTowardWaypoint()
    {
        {
            var targetPos = target.position; // target position
            targetPos.y = transform.position.y; //set targetPos y equal to mine, so I only look at my own plane
            var targetDir = Quaternion.LookRotation(targetPos - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetDir, rotSpeed * Time.deltaTime);     
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Waypoint")
        {
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "Terrain")
        {
            movementDistance = 0;
        }
        if(other.tag == "Ship")
        {
            movementDistance = 0;
        }
    }
}
