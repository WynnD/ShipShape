using UnityEngine;
using System.Collections;

public class Enemy_Test : MonoBehaviour
{
    public int health;
    public float sinkSpeed;

    void Start()
    {

    }


    void Update()
    {
        if (health <= 0)
        {
            Sink();
        }
    }

    void Sink()
    {
        //sink the ship
        transform.Translate(Vector3.down * sinkSpeed * Time.deltaTime);
        Destroy(this.gameObject, 30);
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
