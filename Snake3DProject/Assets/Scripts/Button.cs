using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {

    public void play() {

        SceneManager.LoadScene("Level");

    }

    public void menu()
    {

        SceneManager.LoadScene("First");

    }
    public void exit() {

        Application.Quit();
    
    }
	
}
