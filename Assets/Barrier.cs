using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

 private void OnTriggerEnter(Collider other)
{	Debug.Log(other.name +"crash");
	if ( other.name == "player")
	{
	   Time.timeScale = 0;
	}
}
}
