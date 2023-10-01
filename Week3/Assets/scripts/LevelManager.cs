using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{

  

    // Update is called once per frame
    void Update()
    {

        if (GameObject.FindGameObjectWithTag("GlobalLight"))
        {
            if (GameObject.FindGameObjectWithTag("GlobalLight").GetComponent<Light2D>().enabled == true)
            {
                StartCoroutine(LoadLevel());
            }
        }
       
        
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
        
    }

    IEnumerator LoadLevel()
    {
        yield return new WaitForSecondsRealtime(4);
        LoadNextScene();
    }
}
