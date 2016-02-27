using UnityEngine;
using System.Collections;

public class Enemy_Test : MonoBehaviour
{
    public int health;

    void Start()
    {

    }


    void Update()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "CannonBall")
        {
            health -= 2;
            Debug.Log(health);
        }
    }
}
