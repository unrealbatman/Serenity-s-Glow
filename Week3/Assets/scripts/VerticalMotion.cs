using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMotion : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 upperBound;
    public Vector3 lowerBound;
    private Rigidbody2D bow;

    void Start()
    {
        bow = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y < upperBound.y)
        {
            this.transform.position += moveSpeed * Time.deltaTime * Vector3.up;
        }

        if (Input.GetKey(KeyCode.S) && transform.position.y > lowerBound.y)
        {
            this.transform.position += moveSpeed * Time.deltaTime * Vector3.down;
        }
    }
}
