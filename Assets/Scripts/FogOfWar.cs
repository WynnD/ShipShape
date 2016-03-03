using UnityEngine;
using System.Collections;

public class FogOfWar : MonoBehaviour
{

    float distance;
    int detect_range;
    GameObject[] friends;
    GameObject[] enemies;
    Enemy_Test enemy_script;

    void Start()
    {

    }

    // Use this for initialization
    void Awake()
    {
        enemy_script = this.GetComponent<Enemy_Test>();

        friends = GameObject.FindGameObjectsWithTag("P1Ship");
        enemies = GameObject.FindGameObjectsWithTag("P2Ship");

    }

    // Update is called once per frame
    void Update()
    {



        foreach (GameObject enemy in enemies)
        {
            enemy_script.visible = false;
            detect_range = enemy_script.detect_range;
            
            foreach (GameObject friend in friends)
            {
                if (isDetectable(enemy, friend, detect_range))
                {
                    enemy_script.visible = true;
                    break;
                }

            }
            Debug.Log("Enemy visibility has been set to " + enemy_script.visible);

        }
    }

    private bool isDetectable(GameObject enemy, GameObject friend, int detect_range)
    {
        float distance = Vector3.Distance(enemy.transform.position, friend.transform.position);
        Debug.Log("Distance equals " + distance + " and detect range equals: "+detect_range);

        return (distance < detect_range);
    }
}