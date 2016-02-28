using UnityEngine;
using System.Collections;

public class CannonBall : MonoBehaviour
{

    public GameObject aimWayPoint;
    public Rigidbody rb;
    public float speed;
    public GameObject explosion;
    public float innacuracyRating;

    private Vector3 randomDir;


	void Start ()
    {
        aimWayPoint = GameObject.Find("AimingCube(Clone)");
        rb = this.gameObject.GetComponent<Rigidbody>();

        transform.LookAt(aimWayPoint.transform);

        transform.Rotate(
            Random.Range(-innacuracyRating, innacuracyRating),
            Random.Range(-innacuracyRating, innacuracyRating),
            Random.Range(-innacuracyRating, innacuracyRating));

        rb.AddRelativeForce(Vector3.forward * speed);
	}

    void Update()
    {
        Destroy(this.gameObject, 5);
    }


    void OnCollisionEnter(Collision other)
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
