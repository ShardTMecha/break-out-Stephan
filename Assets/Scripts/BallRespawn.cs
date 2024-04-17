using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallRespawn : MonoBehaviour
{
    public GameObject Ball;

    private void Update()
    {
        SpawnBall();
    }
    void SpawnBall()
    {
        bool doSpawn = Input.GetKeyDown(KeyCode.Space);

        if (doSpawn)
        {
            Instantiate(Ball, transform.position, Quaternion.identity);
        }
    }

}
