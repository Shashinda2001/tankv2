using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveleftandright : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 tempPos;
    bool movingRight = true; // Flag to determine direction
    public float left;
    public float right;
    void Start()
    {
        tempPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (movingRight)
        {
            tempPos.x += 0.05f;
            if (tempPos.x > left)
            {
                movingRight = false;
            }
        }
        else
        {
            tempPos.x -= 0.05f;
            if (tempPos.x < right)
            {
                movingRight = true;
            }
        }

        transform.position = tempPos;
    }
}
