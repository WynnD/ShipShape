using UnityEngine;
using System.Collections;

public class ShipShooting : MonoBehaviour
{
    //HANDLES SHIP SHOOTING


    public int cannons;
    public GameObject cannonBall;
    private MouseClickedMe clickedScript;


    void Start()
    {
        clickedScript = this.gameObject.GetComponent<MouseClickedMe>(); // the ClickedMeScript
    }

    void shoot()
    {
        StartCoroutine(shootAsync());
    }

    IEnumerator shootAsync()
    {
        for (int i = 0; i < cannons; i++) // shoot cannons
        {
            Instantiate(cannonBall, transform.position, transform.rotation); // create cannonball
            yield return new WaitForSeconds(Random.Range(0.1f,0.5f)); // wait to fire next cannonball
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (clickedScript.shipEnabled == true) // if the ship is selected
            {
                if (clickedScript.shootingEnabled == true) // shoot button has been pressed
                {
                    shoot();
                }
            }
        }
    }



}
