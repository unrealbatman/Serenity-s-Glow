using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMotion : MonoBehaviour
{
    public float moveSpeed;
    public float upperBound = 5.0f;
    public float lowerBound = -5.0f;
    private Rigidbody2D bow;

    void Start()
    {
        bow = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y < upperBound)
        {
            this.transform.position += moveSpeed * Time.deltaTime * Vector3.up;
        }

        if (Input.GetKey(KeyCode.S) && transform.position.y > lowerBound)
        {
            this.transform.position += moveSpeed * Time.deltaTime * Vector3.down;
        }
    }
}
