using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    
    private Camera cam;
    private Vector3 mousePos;
    private Vector2 rotationDirection;


    public float force;

    public GameObject pointPrefab;

    public GameObject[] points;

    public int numberOfPoints;



    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.FindAnyObjectByType(typeof(Camera)) as Camera;
        points = new GameObject[numberOfPoints];
        for(int i = 0; i < numberOfPoints; i++)
        {
            points[i] = Instantiate(pointPrefab,transform.position,Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
         rotationDirection = mousePos - this.transform.position;
        this.transform.right = rotationDirection; 
        float angle  = Mathf.Atan2(rotationDirection.y, rotationDirection.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.Euler(0,0,angle);

        for(int i = 0;i < points.Length;i++)
        {
            points[i] .transform.position = PointPosition(i*0.1f);
        }

    }

    Vector2 PointPosition (float time)
    {
        Vector2 CurrentPosition = (Vector2) transform.position + (force * time * rotationDirection.normalized) + (time * time) * 0.5f * Physics2D.gravity;
       return CurrentPosition;
    }
   
}
