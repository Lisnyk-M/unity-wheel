using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheel_root : MonoBehaviour
{
    private bool moveW = false;
    private bool moveS = false;
    private bool moveA = false;
    private bool moveD = false;
    private float speed = 7.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.position.y < -20)
        //{
        //    Application.Quit();
        //}
        // при зажатии определённой клавиши
        if (Input.GetKeyDown(KeyCode.W)) moveW = true;
        if (Input.GetKeyDown(KeyCode.S)) moveS = true;

        // при отпускании определённой клавиши
        if (Input.GetKeyUp(KeyCode.W)) moveW = false;
        ////if (Input.GetKeyUp(KeyCode.S)) moveS = false;
        if (Input.GetKeyUp(KeyCode.S)) moveS = false;

        // при зажатии определённой клавиши
        if (Input.GetKeyDown(KeyCode.A)) moveA = true;
        if (Input.GetKeyDown(KeyCode.D)) moveD = true;

        // при отпускании определённой клавиши
        if (Input.GetKeyUp(KeyCode.A)) moveA = false;
        if (Input.GetKeyUp(KeyCode.D)) moveD = false;

        if (moveW == true) gameObject.transform.Translate(0, 0, Time.deltaTime * speed);
        if (moveS == true) gameObject.transform.Translate(0, 0, Time.deltaTime * speed * (-1));
        if (moveA == true) gameObject.transform.Rotate(0, -Time.deltaTime * speed * 10, 0);
        if (moveD == true) gameObject.transform.Rotate(0, Time.deltaTime * speed * 10, 0);
    }
}
