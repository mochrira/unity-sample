using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public KeyCode moveRight;
    public KeyCode moveLeft;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        string position = getColumnPosition();
        switch (position)
        {
            case "center": keyOnCenter(); break;
            case "right": keyOnRight(); break;
            default: keyOnLeft(); break;
        }
    }

    void keyOnCenter()
    {
        if (Input.GetKeyDown(moveRight))
            transform.position = new Vector3(2.5f, transform.position.y, transform.position.z);

        if (Input.GetKeyDown(moveLeft))
            transform.position = new Vector3(0.5f, transform.position.y, transform.position.z);
    }

    void keyOnRight()
    {
        if (Input.GetKeyDown(moveLeft))
            transform.position = new Vector3(1.5f, transform.position.y, transform.position.z);
    }

    void keyOnLeft()
    {
        if (Input.GetKeyDown(moveRight))
            transform.position = new Vector3(1.5f, transform.position.y, transform.position.z);
    }

    string getColumnPosition()
    {
        if (Mathf.Approximately(transform.position.x, 1.5f)) return "center";
        if (Mathf.Approximately(transform.position.x, 2.5f)) return "right";
        return "left";
    }

}
