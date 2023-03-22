using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_script : MonoBehaviour
{
    public bool IsBirdAlive = true;
    public Rigidbody2D my_body;
    public float up_velocity;
    public LogicScript logic;
    public GameObject Boom;
    public AudioSource my_explosion;
    public AudioSource background_music;
    private bool is_spawned = false;
    // Start is called before the first frame update
    void Start()
    {
        background_music.Play();
        Time.timeScale = 1;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsBirdAlive)
        {
            my_body.velocity = Vector2.up * up_velocity;
        }
        if (IsBirdAlive == false)
        {
            my_body.velocity = Vector3.zero;
            my_body.gravityScale = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        background_music.Stop();
        my_body.GetComponent<Renderer>().enabled = false;
        if (is_spawned == false)
        {
            Instantiate(Boom, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
            my_explosion.Play();
        }
        is_spawned = true;
        logic.GameOver();
        IsBirdAlive = false;
    }
}
