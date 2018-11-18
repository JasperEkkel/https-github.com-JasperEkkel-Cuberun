using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauzeMenu : MonoBehaviour {

    public static bool GameIsPaused = false;

    public GameObject pauzeMenuUI;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            } else 
            {
                Pause();
            }
        }

	}
    public void Resume ()
    {
        pauzeMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    
    void Pause () 
    {
        pauzeMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

}

