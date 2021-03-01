using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTrigger : MonoBehaviour
    
{
    public GameObject explosion;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hit detected");
        GameObject e = Instantiate(explosion) as GameObject;
        e.transform.position = transform.position;
        Destroy(collision.gameObject);
        this.gameObject.SetActive(false);
    }
}
