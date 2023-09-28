using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class collisionHandler : MonoBehaviour
{
    public float smoothTime=0.5f;
    public float targetIntensity = 5.0f; // The intensity you want to reach

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Destroy"))
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Target"))
        {
            Debug.Log("Target hit");
            Animator anim = collision.gameObject.GetComponentInChildren<Animator>();
            anim.SetTrigger("Fire");

            SpriteRenderer rend = collision.gameObject.GetComponentInChildren(typeof(SpriteRenderer), true) as SpriteRenderer;
           
            Debug.Log(rend.name);            
            Light2D light2D = collision.gameObject.GetComponent<Light2D>();
            StartCoroutine(IncreaseIntensityOverTime(light2D));
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            collision.GetComponent<PolygonCollider2D>().enabled = false;

        }

    }

    IEnumerator IncreaseIntensityOverTime(Light2D light2D)
    {
        float startIntensity = 0f;

        float elapsedTime = 0;

        while (elapsedTime < smoothTime)
        {
            light2D.intensity = Mathf.Lerp(startIntensity, targetIntensity, elapsedTime / smoothTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        light2D.intensity = targetIntensity;
    }


}
