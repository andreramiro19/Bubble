using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ready : MonoBehaviour
{

    public Animator readyGo;
    public float transitionTime = 3f;

    // Start is called before the first frame update

    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = 0f;
    }
    
}
