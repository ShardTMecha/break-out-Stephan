using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("+100pts");
        bool isPlayerObject = collider.gameObject.CompareTag("Player");

        Rigidbody2D rg2d = collider.attachedRigidbody;
        rg2d.velocity = new Vector2(rg2d.velocity.x, -rg2d.velocity.y);

        Destroy(this.gameObject);

    }

    
}
