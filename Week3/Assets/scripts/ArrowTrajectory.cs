using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowTrajectory : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        TrackMovement();
    }
    void TrackMovement()
    {

        Vector2 direction = rb.velocity;
        float angle = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

    }
}
