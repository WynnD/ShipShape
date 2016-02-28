using UnityEngine;
using System.Collections;

public class DeleteAfterTime : MonoBehaviour
{
    public float timer;
	void Start ()
    {
        Destroy(this.gameObject, timer);
    }
}
