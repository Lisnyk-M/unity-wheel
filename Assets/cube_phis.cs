using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_phis : MonoBehaviour
{
    //public GameObject cubePh;
    public float torque;
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float turn = Input.GetAxis("Vertical");
        rb.AddForce(-transform.right * torque * turn * 1);
    }
}
