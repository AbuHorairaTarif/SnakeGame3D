using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackBut : MonoBehaviour {

    public void play() {

        SceneManager.LoadScene("First");

    }

    public void menu()
    {

        SceneManager.LoadScene("Level");

    }
    public void exit() {

        Application.Quit();
    
    }
	
}
