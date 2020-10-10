using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private float speed = -12;

    private float deadLine = -10;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "CubeTag" || collision.gameObject.tag == "GroundTag")
        {
            audioSource.Play();
        }
    }   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.speed * Time.deltaTime, 0, 0);
        
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }
}
