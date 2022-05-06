using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheel : MonoBehaviour
{
    private bool moveW = false;
    private bool moveS = false;
    //private bool moveA = false;
    //private bool moveD = false;
    private float speed = 7.0f;
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        //Debug.Log($"GetAxis: {h}");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Debug.Log("ESCAPE");
            Application.Quit();
        }
        // ��� ������� ����������� �������
        if (Input.GetKeyDown(KeyCode.W)) moveW = true;
        if (Input.GetKeyDown(KeyCode.S)) moveS = true;

        // ��� ���������� ����������� �������
        if (Input.GetKeyUp(KeyCode.W)) moveW = false;
        if (Input.GetKeyUp(KeyCode.S)) moveS = false;

        // ��� ������� ����������� �������
        //if (Input.GetKeyDown(KeyCode.A)) moveA = true;
        //if (Input.GetKeyDown(KeyCode.D)) moveD = true;

        //// ��� ���������� ����������� �������
        //if (Input.GetKeyUp(KeyCode.A)) moveA = false;
        //if (Input.GetKeyUp(KeyCode.D)) moveD = false;

        if (moveW == true)
        {
            //gameObject.transform.Translate(0, 0, Time.deltaTime * speed);
            gameObject.transform.Rotate(Time.deltaTime * speed * 50, 0, 0);
        }
        if (moveS == true)
        {
            gameObject.transform.Rotate(-Time.deltaTime * speed * 50, 0, 0);
        }
    }
    private void OnMouseDown()
    {
        Debug.Log("mouse down");
    }
}
