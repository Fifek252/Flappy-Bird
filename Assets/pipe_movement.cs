using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_movement : MonoBehaviour
{
    public float movespeed = 5;
    public float out_of_bounds = -32;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * movespeed * Time.deltaTime;
        if(transform.position.x < out_of_bounds)
        {
            Destroy(gameObject);
        }
    }
}
