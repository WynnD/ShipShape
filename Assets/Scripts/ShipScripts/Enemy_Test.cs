using UnityEngine;
using System.Collections;

public class Enemy_Test : MonoBehaviour
{
    public int health;
    public float sinkSpeed;
    public int detect_range;
    public MeshRenderer[] renderers;
    public bool visible;
    FogOfWar fow_script;


    void Start()
    {
        renderers = GetComponentsInChildren<MeshRenderer>();
        fow_script = GetComponent<FogOfWar>();
    }


void Update()
    {
        if (health <= 0)
        {
            Sink();
        }


        foreach (MeshRenderer rend in renderers)
            rend.enabled = visible;
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
