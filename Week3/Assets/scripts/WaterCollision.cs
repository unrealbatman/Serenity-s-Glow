using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class WaterCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {

            collision.gameObject.GetComponentsInChildren<SpriteRenderer>()[1].enabled = false;
            
            collision.gameObject.GetComponent<PolygonCollider2D>().enabled = false;

        }
    }

   
}
