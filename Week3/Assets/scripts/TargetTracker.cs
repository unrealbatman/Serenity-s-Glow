using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class TargetTracker : MonoBehaviour
{
    GameObject[] targets;



    // Variable to keep track of trigger status
    bool allTriggersFalse = true;

    // Start is called before the first frame update
    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("Target");
        
    }

    // Update is called once per frame
    void Update()
    {
        allTriggersFalse = true; // Reset the flag at the start of each frame

        for (int i = 0; i < targets.Length; i++)
        {
            if (targets[i].GetComponent<PolygonCollider2D>().isActiveAndEnabled)
            {
                allTriggersFalse = false;
                break; // If you find a trigger, no need to check further
            }
        }

        if (allTriggersFalse)
        {

            StartCoroutine(EnableGlobalLight());
            // All targets have isTrigger set to false
        }
        else
        {
            this.gameObject.GetComponent<Light2D>().enabled = false;

           
        }
    }
    IEnumerator EnableGlobalLight()
    {
       
        yield return new WaitForSecondsRealtime(2);

        this.gameObject.GetComponent<Light2D>().enabled = true;

        GameObject[] water = GameObject.FindGameObjectsWithTag("Water");

        for(int i =0; i < water.Length; i++)
        {
            water[i].SetActive(false);
        }

    }
}
