using UnityEngine;
using System.Collections;

public class ShipShooting : MonoBehaviour
{
    //HANDLES SHIP SHOOTING


    //Wynn Code here
    /*
    public MouseClickedMe clickedScript;
    public GameObject shell = GameObject.Find("Shell");
    int power;
    public float x_dest;
    public float z_dest;
    public float y_height = 8.19F;
    //Vector3 vector = new Vector3(x, 0, camera.main.ScreenToWorldPoint());
    Camera maincam;

    // get mouse position
    Ray getMouseLocation()
    {
        maincam = Camera.main;
        Ray ret = maincam.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

        return ret;
    }

    void Start ()
    {
        shell.SetActive(true); // activate shell

    }

    void Update ()
    {
        if (clickedScript.shipEnabled == true) // if the ship is selected
        {

        }        
    }*/



    //JUSTIN CODE HERE







    private MouseClickedMe clickedScript;


    void Start()
    {
        clickedScript = this.gameObject.GetComponent<MouseClickedMe>(); // the ClickedMeScript
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Mouse Clicked");
            if (clickedScript.shipEnabled == true) // if the ship is selected
            {
                Debug.Log("Ship Enabled");
                if (clickedScript.shootingEnabled == true) // shoot button has been pressed
                {
                    Debug.Log("Ship enabled and able to fire");
                }
            }
        }
    }



}
