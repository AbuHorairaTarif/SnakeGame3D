using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClassicBut : MonoBehaviour {

    public void play() {

        SceneManager.LoadScene("Classic");

    }

    public void menu()
    {

        SceneManager.LoadScene("Level");

    }
    public void exit() {

        Application.Quit();
    
    }
	
}
