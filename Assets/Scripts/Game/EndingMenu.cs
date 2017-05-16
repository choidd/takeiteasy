using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButton_Restart()
    {
        SceneManager.LoadScene("tmp");
        Time.timeScale = 1.0f;
    }

    public void OnButton_Showranking()
    {

    }

    public void OnButtton_Exit()
    {
        Application.Quit();
    }
}
