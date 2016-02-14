using UnityEngine;
using System.Collections;



//TURNS ON AND OFF THE CANVAS


public class CanvasEnabled : MonoBehaviour
{
    public GameObject ship;
    private MouseClickedMe clickedScript;


    void Start()
    {
        clickedScript = ship.GetComponent<MouseClickedMe>(); // the ClickedMeScript
    }

    void Update()
    {
        if(clickedScript.shipEnabled == true)
        {
            //show GUI
            Enable();
        }
        else
        {
            //do not show GUI
            Disable();
        }
    }

	public void Disable() // disables ship gui
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false); // turns off all the canvas objects
        }
    }

    public void Enable() // enables ship gui
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(true); // turns on all the canvas objectsz
        }
    }

    public void DisableShip()
    {
        clickedScript.shipEnabled = false;
    }
}
