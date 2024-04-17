using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Break out
//the player bar
public class Player : MonoBehaviour
{
    public GameObject Ball;
    public float speed = 10;
    public GameObject Bar;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame

    void FixedUpdate()
    {
        Move();
        bool doSpawn = Input.GetKeyDown(KeyCode.Space);

        if (doSpawn)
        {
            Instantiate(Ball, transform.position, Quaternion.identity);
        }
    }

    void Move()
    {
        Vector3 offset = Vector3.zero;
        // the "A" and "D" keys will be what you use to move
        bool isHoldingLeft = Input.GetKey(KeyCode.A);
        bool isHoldingRight = Input.GetKey(KeyCode.D);

        if (isHoldingLeft)
            offset.x -= speed;
        if (isHoldingRight)
            offset.x += speed;

        transform.position += offset * Time.deltaTime;
    }






}

