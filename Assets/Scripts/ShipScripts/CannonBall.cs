using UnityEngine;
using System.Collections;

public class CannonBall : MonoBehaviour
{

    public GameObject aimWayPoint;
    public Rigidbody rb;
    public float speed;
    public GameObject explosion;


	void Start ()
    {
        aimWayPoint = GameObject.Find("AimingCube(Clone)");
        rb = this.gameObject.GetComponent<Rigidbody>();

        transform.LookAt(aimWayPoint.transform);
        rb.AddRelativeForce(Vector3.forward * speed);
	}


    void OnCollisionEnter(Collision other)
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
