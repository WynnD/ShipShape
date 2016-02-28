using UnityEngine;
using System.Collections;

public class FogOfWar : MonoBehaviour
{

    float distance;
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

        friends = GameObject.FindGameObjectsWithTag("Player 1");
        enemies = GameObject.FindGameObjectsWithTag("Player 2");

    }

    // Update is called once per frame
    void Update()
    {



        foreach (GameObject enemy in enemies)
        {
            enemy_script.visible = false;
            foreach (GameObject friend in friends)
            {
                if (isDetectable(enemy, friend, enemy_script))
                {
                    enemy_script.visible = true;
                    break;
                }

            }
            Debug.Log("Enemy visibility has been set to " + enemy_script.visible);

        }
    }

    private bool isDetectable(GameObject enemy, GameObject friend, Enemy_Test script)
    {
        int detect_range = script.detect_range;
        float distance = Vector3.Distance(enemy.transform.position, friend.transform.position);
        Debug.Log("Distance equals: " + distance);

        return (distance < detect_range);
    }
}