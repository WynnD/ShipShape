using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    //HANDLES MOVEMENT OF THE CAMERA

    public float movementSpeed;
    public float rotateSpeed;
    public GameObject waypoint;
    public float rayDistance;
    public GameObject playerShip;

    private RaycastHit rayInfo;
    private MouseClickedMe clickedScript;
    private ShipShooting shipShooting;


    void Start ()
    {
        clickedScript = playerShip.GetComponent<MouseClickedMe>(); // the ClickedMeScript
        shipShooting = playerShip.GetComponent<ShipShooting>(); // the ClickedMeScript

    }

    void checkMousePos()
    {
        if (Input.mousePosition.y >= Screen.height * .98)
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        if (Input.mousePosition.y < Screen.height * .02)
            transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);

        if (Input.mousePosition.x >= Screen.width * .98)
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        if (Input.mousePosition.x < Screen.width * .02)
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);


        return;
    }

	void Update ()
    {
        // MOVEMENT
	    if(Input.GetKey(KeyCode.A)) // Move Left
        {
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) // Move Right
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W)) // Move Forward
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)) // Move Back
        {
            transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.Q)) // Rotate Left
        {
            transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.E)) // Rotate Right
        {
            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        }



        //MOVEMENT UP AND DOWN WITH SCROLL WHEEL
        var d = Input.GetAxis("Mouse ScrollWheel");
        if (d > 0f)
        {
            // scroll up
            if(this.transform.position.y > 4) // if you are not too low to the water
            {
                transform.Translate(new Vector3(0, -1, 0));
            } //
        }
        else if (d < 0f)
        {
            // scroll down
            if(this.transform.position.y < 12) // if you are not too high in the sky 
            {
                transform.Translate(new Vector3(0, 1, 0));
            }
        }

        // check if mouse is on side of screen, and scroll accordingly
        checkMousePos();


        // end camera movement section

        // WAYPOINT SPAWNING
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (clickedScript.shipEnabled == true) // if the ship is selected
            {
                if(clickedScript.wayPointEnabled == true) // move button has been pressed
                {
                    Ray toMouse = Camera.main.ScreenPointToRay(Input.mousePosition); // the position of the mouse on the screen
                    RaycastHit rhInfo; // contains all of the information about the object clicked on. Including position and name.
                    bool didHit = Physics.Raycast(toMouse, out rhInfo, rayDistance);

                    if (didHit) // if you clicked on something
                    {
                        if (rhInfo.collider.name == "Waypoint(Clone")
                        {
                            Debug.Log("TouchedWaypoint");
                        }
                        if (rhInfo.collider.name == "WaterPlane") // if you clicked on the water
                        {
                            Instantiate(waypoint, rhInfo.point, Quaternion.identity); // create waypoint where you clicked
                        }
                        clickedScript.wayPointEnabled = false;
                    }
                    else // you didnt click on anything
                    {
                        Debug.Log("Didn't hit anything");
                    }
                }//////////////////////////////////////////////////////////////////

                //SHOOTING 
                if(clickedScript.shootingEnabled)
                {

                }
            }
        }
    }
}
