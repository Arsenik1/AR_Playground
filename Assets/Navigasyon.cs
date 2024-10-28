using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    public void right()
    {
        // Get the current scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (SceneManager.GetActiveScene().name == "Scenario 8")
        {
            // Load the next scene
            SceneManager.LoadScene(0);
        }
        else
        {
            // Load the next scene
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        print("Scene index: " + currentSceneIndex);
    }

    public void left()
    {
        // Get the current scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (SceneManager.GetActiveScene().name == "MAIN")
        {
            // Load the previous scene
            SceneManager.LoadScene(8);
        }
        else
        {
            // Load the previous scene
            SceneManager.LoadScene(currentSceneIndex - 1);
        }
        print("Scene index: " + currentSceneIndex);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
