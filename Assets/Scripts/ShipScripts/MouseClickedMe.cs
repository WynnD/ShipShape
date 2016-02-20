using UnityEngine;
using System.Collections;



//THIS SCRIPT HANDLES WHAT SHIPS ARE ALLOWED TO DO ONCE THEY HAVE BEEN CLICKED ON



public class MouseClickedMe : MonoBehaviour
{
    public bool shipEnabled;
    public bool wayPointEnabled;
    public bool shootingEnabled;

    void Start()
    {
        shipEnabled = false;
        wayPointEnabled = false;
        shootingEnabled = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1)) // cancel
        {
            shipEnabled = false;
            wayPointEnabled = false;
            shootingEnabled = false;
        }
    }

    void OnMouseDown()
    {
        // this object was clicked - do something
        shipEnabled = true;
    }

    public void MoveShipButtonPressed(bool clicked) // when you click the "move" button
    {
        Debug.Log("Hit Move button");
        wayPointEnabled = true;
    }

    public void DisableShip()
    {
        shipEnabled = false;
    }

    public void ShootButtonPressed(bool clicked) // when you click the "shoot" button
    {
        Debug.Log("Hit the shoot button");
        shootingEnabled = true;
    }
}
