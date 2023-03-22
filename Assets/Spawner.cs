using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipes;
    public float spawn_delay = 2.5F;
    private float timer;
    public float height_offset = 10;
    public float lowest_point;
    public float highest_point;
    // Start is called before the first frame update
    void Start()
    {
        lowest_point = transform.position.y - height_offset;
        highest_point = transform.position.y + height_offset;
        spawn_pipes();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawn_delay)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawn_pipes();
        }
    }

    void spawn_pipes()
    {
        Instantiate(pipes, new Vector3(transform.position.x, Random.Range(lowest_point, highest_point), transform.position.z), transform.rotation);
        timer = 0;
    }
}
