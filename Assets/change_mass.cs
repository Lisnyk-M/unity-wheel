using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_mass : MonoBehaviour
{
    public GameObject cube1;
    public GameObject cube2;
    void Start()
    {
        cube1.GetComponent<Rigidbody>().mass = 5;
        cube2.GetComponent<Rigidbody>().mass = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
