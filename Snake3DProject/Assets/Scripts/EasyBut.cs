using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasyBut : MonoBehaviour {

    public void play() {

        SceneManager.LoadScene("Play");

    }

    public void menu()
    {
        
       
        SceneManager.LoadScene("Level");

    }
    public void exit() {

        Application.Quit();
    
    }
	
}
