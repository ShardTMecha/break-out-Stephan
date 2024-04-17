using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Vector3 orginalPosition = gameObject.transform.position;
        if (other.gameObject.tag == "Try Again")
        {
            gameObject.transform.position = orginalPosition;
        }

    }
}
