using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceBubble : MonoBehaviour
{

    [SerializeField]
    Transform player;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float moveSpeed;

    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //distance to player
        float distToPlayer = Vector2.Distance(transform.position, player.position);
        if (distToPlayer < agroRange)
        {
            //code to chase player
            faceMouse();
        }
        else
        {
            //stop chasing player
            StopfaceMouse();
        }

    }

    void faceMouse()
    {
        //Vector3 mousePosition = Input.mousePosition;
        //mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        player.GetComponent<Rigidbody2D>().AddForce(-transform.forward * 500);

        Vector2 direction = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);

        transform.right = direction;
    }

    void StopfaceMouse()
    {
        Vector2 direction2 = new Vector2(0, 0);            
    }
}
