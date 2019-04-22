using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGeneration : MonoBehaviour {

	public float XSize = 8.8f;
	public float ZSize = 8.8f;
	public GameObject foodPrefab;
	public Vector3 curPos;
	// Use this for initialization
	public GameObject curFood;

	void AddNewFood()
	{
		RandomPos ();
		curFood = GameObject.Instantiate (foodPrefab,curPos,Quaternion.identity) as GameObject;
	}
	void RandomPos() 
	{
		curPos = new Vector3 (Random.Range (XSize*-1,XSize),0.25f,Random.Range (ZSize*-1,ZSize));
	}

	// Update is called once per frame
	void Update () {
		if (!curFood) {
			AddNewFood ();
		} 
		else 
		{
			return;
		}
	}
}
