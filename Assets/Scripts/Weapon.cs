using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform firePoint;

    [SerializeField]
    Transform player;
    AreaEffector2D ae;

    public float distance = 1f;
    public LayerMask bubbleMask;


    //teste
    public float forceFactor = 10f;
    private float kickForce = 0f;
    private EdgeCollider2D BatCollider;
    public GameObject Ball;
    //teste

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }

    void Shoot()
    {
        RaycastHit2D hitInfo =  Physics2D.Raycast(firePoint.position, firePoint.right);

        if (hitInfo)
        {
            Debug.Log(hitInfo.transform.name);
            player.transform.position += transform.forward * Time.deltaTime;
        }
    }

    void Shoot2()
    {
        Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, distance, bubbleMask);
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + Vector2.right * transform.localScale.x * distance);
    }

}
