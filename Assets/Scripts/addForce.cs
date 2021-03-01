using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addForce : MonoBehaviour
{
    public float moveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 direction = (new Vector2(moveSpeed, 0));
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = (new Vector2(moveSpeed, 0));      
    }
}
