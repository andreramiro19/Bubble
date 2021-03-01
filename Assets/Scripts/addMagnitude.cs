using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addMagnitude : MonoBehaviour
{
    AreaEffector2D ae2d;
    SpriteRenderer sp;

    public float forceMagnitude;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           // Shoot();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            this.gameObject.GetComponent<AreaEffector2D>().forceMagnitude = forceMagnitude;
        }
        else
        {
            this.gameObject.GetComponent<AreaEffector2D>().forceMagnitude = 0;
        }        
    }

    void Shoot()
    {

        //ae2d.forceMagnitude = 10f;
        this.gameObject.GetComponent<AreaEffector2D>().forceMagnitude = 10;

    }
}
