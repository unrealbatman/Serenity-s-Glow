using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{

    [SerializeField]
    private GameObject Projectile;

    [SerializeField]
    private float launchForce;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

     void Shoot()
    {
        GameObject ArrowIns = Instantiate(Projectile,transform.position, transform.rotation);
        ArrowIns.GetComponent<Rigidbody2D>().AddForce  (transform.right * launchForce);
    }

    
}