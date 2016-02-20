using UnityEngine;
using System.Collections;

public class ShipShooting : MonoBehaviour
{
    public MouseClickedMe clickedScript;
    public GameObject shell = GameObject.Find("Shell");
    int power;
    public float x_dest;
    public float z_dest;
    public float y_height = 8.19F;
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
            

        
    }
}
