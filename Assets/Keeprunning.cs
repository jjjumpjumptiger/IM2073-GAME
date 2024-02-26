using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keeprunning : MonoBehaviour
{
    public float speed = 10;
    public float turnSpeed = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        transform.Translate(x * turnSpeed * Time.deltaTime, 0 ,speed * Time.deltaTime);
    }
}
