using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFallMovement : MonoBehaviour
{
    public Vector3 pointA;
    public Vector3 pointB;
    public float speed = 2.0f;

    private Vector3 targetPosition;

    void Start()
    {
        targetPosition = pointB; // Start at point B
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (transform.position == targetPosition)
        {
            // Toggle between points A and B
            if (targetPosition == pointA)
            {
                targetPosition = pointB;
            }
            else
            {
                targetPosition = pointA;
            }
            
        }
    }
}
