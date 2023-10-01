using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class ShootProjectile : MonoBehaviour
{

    [SerializeField]
    private GameObject Projectile;

    [SerializeField]
    private float launchForce;
 
    private AudioSource audioSource;

    public int ammo=5;
    // Update is called once per frame
    void Update()
    {
        audioSource = GetComponent<AudioSource>();
        if (Input.GetKeyUp(KeyCode.Mouse0) && ammo != 0)
        {
            Shoot();
            audioSource.priority = 0;
            audioSource.PlayOneShot(audioSource.clip);
        }

       TextMeshProUGUI textInput = GameObject.FindGameObjectWithTag("Ammo").GetComponent<TextMeshProUGUI>();
       textInput.text =ammo.ToString();
        if (ammo == 0)
        {
            if (GameObject.FindGameObjectWithTag("GlobalLight"))
            {
                if (GameObject.FindGameObjectWithTag("GlobalLight").GetComponent<Light2D>().enabled == true)
                {

                }
                else
                {
                    StartCoroutine(loadGameOver());
                }
            }
        }
        
    }

     void Shoot()
    {
        GameObject ArrowIns = Instantiate(Projectile,transform.position, transform.rotation);
        ArrowIns.GetComponent<Rigidbody2D>().AddForce(transform.right * launchForce);
        ammo--;
    }

    IEnumerator loadGameOver()
    {
        yield return new WaitForSecondsRealtime(3);
        SceneManager.LoadScene(2);
    }
    
}