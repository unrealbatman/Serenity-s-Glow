using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMotion : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D bow;
    // Start is called before the first frame update
    void Start()
    {
        bow = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
    }
}