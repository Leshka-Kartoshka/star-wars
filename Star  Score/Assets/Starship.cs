using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Starship : MonoBehaviour
{
    float delta = 0;
    public GameObject bullet;
    public GameObject gun;
    float velo = 200f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {   
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(moveX * velo, moveY * velo, 0);
        if(Time.time > delta + 1)
        {
            if(Input.GetMouseButtonDown(0))
            {
                Instantiate(bullet, gun.transform.position, Quaternion.identity);
                delta = Time.time;
            }
        }
    }
}