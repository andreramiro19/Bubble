using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbleCollision : MonoBehaviour
{
    public GameObject explosion;

    // Start is called before the first frame update

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Wall")
        {
            FindObjectOfType<AudioManager>().Play("PlayerDeath");

            Debug.Log("hit detected");
            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
            Destroy(gameObject);
            //this.gameObject.SetActive(false);
            
        }
    }
}
