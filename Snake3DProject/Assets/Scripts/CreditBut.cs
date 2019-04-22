using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditBut : MonoBehaviour {

    public void play() {

        SceneManager.LoadScene("Credits");

    }

    public void menu()
    {

        SceneManager.LoadScene("First");

    }
    public void exit() {

        Application.Quit();
    
    }
	
}
