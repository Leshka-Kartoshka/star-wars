using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGenerator : MonoBehaviour
{
    float nextTime = 1;
    public GameObject asteroid;
    float positionY = 295;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextTime + 1.1f)
        {
            Instantiate(asteroid, new Vector3(Random.Range(-145, 145), 295, 0), Quaternion.identity);
            nextTime = Time.time;
        }
    }
}
