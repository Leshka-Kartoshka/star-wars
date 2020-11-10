using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    Rigidbody rb;
    public GameObject starship;
    public GameObject lazer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0, -200f, 0);
    }
    void OnTriggerEnter(){
        Destroy(starship);
        Destroy(lazer);
    }
}