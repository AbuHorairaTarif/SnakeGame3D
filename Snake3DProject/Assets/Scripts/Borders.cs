using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Borders : MonoBehaviour {
   // public Text ScoreText;

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("SnakeMain")) 

			{
                
              //  ScoreText.text = "Game OVER"+score.ToString ();
				SceneManager.LoadScene("Level");
			}
		}
	}
