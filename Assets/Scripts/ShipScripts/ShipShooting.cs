using UnityEngine;
using System.Collections;

public class ShipShooting : MonoBehaviour
{
    //HANDLES SHIP SHOOTING



    public GameObject cannonBall;
    private MouseClickedMe clickedScript;


    void Start()
    {
        clickedScript = this.gameObject.GetComponent<MouseClickedMe>(); // the ClickedMeScript
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (clickedScript.shipEnabled == true) // if the ship is selected
            {
                if (clickedScript.shootingEnabled == true) // shoot button has been pressed
                {
                    Debug.Log("Ship enabled and able to fire");
                    Instantiate(cannonBall, transform.position, transform.rotation);
                }
            }
        }
    }



}
